using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace ProyectoOdontologia2025
{
    public static class ReportUtils
    {
        public static void ExportToCSV(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Reporte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Headers
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (!dgv.Columns[i].Visible) continue;
                        sb.Append("\"" + dgv.Columns[i].HeaderText.Replace("\"", "\"\"") + "\"" + (i == dgv.Columns.Count - 1 ? "" : ","));
                    }
                    sb.AppendLine();

                    // Rows
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                if (!dgv.Columns[i].Visible) continue;
                                string val = row.Cells[i].Value?.ToString() ?? "";
                                sb.Append("\"" + val.Replace("\"", "\"\"") + "\"" + (i == dgv.Columns.Count - 1 ? "" : ","));
                            }
                            sb.AppendLine();
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Datos exportados exitosamente en: " + Path.GetFileName(sfd.FileName), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void PrintDataGridView(DataGridView dgv, string title, Control chart = null)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            
            // Forzar tamaño de papel estándar (A4 o Letter) para evitar que use el de una impresora térmica por defecto
            bool paperSet = false;
            foreach (PaperSize ps in pd.PrinterSettings.PaperSizes)
            {
                if (ps.PaperName.Equals("A4", StringComparison.OrdinalIgnoreCase) || 
                    ps.PaperName.Equals("Letter", StringComparison.OrdinalIgnoreCase))
                {
                    pd.DefaultPageSettings.PaperSize = ps;
                    paperSet = true;
                    break;
                }
            }
            if (!paperSet)
            {
                pd.DefaultPageSettings.PaperSize = new PaperSize("CustomA4", 827, 1169);
            }
            
            int currentRow = 0;
            bool chartPrinted = false;

            // Resetear el estado al iniciar la impresión (crucial para la vista previa)
            pd.BeginPrint += (s, e) =>
            {
                currentRow = 0;
                chartPrinted = false;
            };

            pd.PrintPage += (s, e) =>
            {
                Graphics g = e.Graphics;
                Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
                Font fontHeader = new Font("Segoe UI", 10, FontStyle.Bold);
                Font fontBody = new Font("Segoe UI", 9);
                
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float width = e.MarginBounds.Width;

                // Dibujar Título
                g.DrawString(title, fontTitle, Brushes.Indigo, new RectangleF(x, y, width, 40), new StringFormat { Alignment = StringAlignment.Center });
                y += 50;

                // Si hay un gráfico y no se ha impreso, imprimirlo en la primera página o al principio
                if (chart != null && !chartPrinted)
                {
                    using (Bitmap bmp = new Bitmap(chart.Width, chart.Height))
                    {
                        chart.DrawToBitmap(bmp, new Rectangle(0, 0, chart.Width, chart.Height));
                        // Ajustar tamaño del gráfico al ancho de la página manteniendo proporción
                        float chartWidth = width;
                        float chartHeight = (float)chart.Height * (width / (float)chart.Width);
                        
                        // Si el gráfico es muy alto, limitarlo
                        if (chartHeight > 300)
                        {
                            chartHeight = 300;
                            chartWidth = (float)chart.Width * (300f / (float)chart.Height);
                        }

                        g.DrawImage(bmp, x + (width - chartWidth) / 2, y, chartWidth, chartHeight);
                        y += chartHeight + 20;
                    }
                    chartPrinted = true;
                }

                // Fecha de impresión
                g.DrawString("Fecha de impresión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontBody, Brushes.Gray, x, y);
                y += 20;

                // Calcular anchos de columna
                var visibleColumns = new System.Collections.Generic.List<DataGridViewColumn>();
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) visibleColumns.Add(col);

                float[] columnWidths = new float[visibleColumns.Count];
                float totalWidth = 0;
                for (int i = 0; i < visibleColumns.Count; i++)
                {
                    columnWidths[i] = g.MeasureString(visibleColumns[i].HeaderText, fontHeader).Width + 20;
                    totalWidth += columnWidths[i];
                }

                float scale = width / totalWidth;
                for (int i = 0; i < visibleColumns.Count; i++) columnWidths[i] *= scale;

                // Encabezados
                float currentX = x;
                for (int i = 0; i < visibleColumns.Count; i++)
                {
                    g.FillRectangle(new SolidBrush(Color.MediumPurple), currentX, y, columnWidths[i], 30);
                    g.DrawRectangle(Pens.Indigo, currentX, y, columnWidths[i], 30);
                    g.DrawString(visibleColumns[i].HeaderText, fontHeader, Brushes.White, new RectangleF(currentX, y, columnWidths[i], 30), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    currentX += columnWidths[i];
                }
                y += 30;

                // Filas
                while (currentRow < dgv.Rows.Count)
                {
                    DataGridViewRow row = dgv.Rows[currentRow];
                    if (row.IsNewRow) { currentRow++; continue; }

                    currentX = x;
                    float rowHeight = 25;

                    if (y + rowHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    for (int i = 0; i < visibleColumns.Count; i++)
                    {
                        string cellValue = row.Cells[visibleColumns[i].Index].Value?.ToString() ?? "";
                        g.DrawRectangle(Pens.LightGray, currentX, y, columnWidths[i], rowHeight);
                        g.DrawString(cellValue, fontBody, Brushes.Black, new RectangleF(currentX + 2, y, columnWidths[i] - 4, rowHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        currentX += columnWidths[i];
                    }
                    y += rowHeight;
                    currentRow++;
                }
                
                e.HasMorePages = false;
                currentRow = 0;
                chartPrinted = false;
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd, Width = 800, Height = 600, Text = "Exportar / Imprimir Reporte" };
            ppd.ShowDialog();
        }

        public static void ExportToPDF(DataGridView dgv, string title, Control chart = null)
        {
            // En .NET Framework sin librerías externas, la mejor forma de "Exportar a PDF" 
            // de manera nativa es usar el driver de impresión "Microsoft Print to PDF".
            // Redirigimos a la función de impresión informando al usuario.
            
            MessageBox.Show("Para exportar a PDF:\n1. Se abrirá la vista previa.\n2. Haga clic en el ícono de impresora.\n3. Seleccione 'Microsoft Print to PDF' como impresora.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrintDataGridView(dgv, title, chart);
        }
    }
}
