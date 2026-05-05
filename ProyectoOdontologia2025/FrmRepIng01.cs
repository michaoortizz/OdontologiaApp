using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoOdontologia2025
{
    public partial class FrmRepIng01 : Form
    {
        // ── Conexión ──────────────────────────────────────────────────────────
        private readonly SqlConnection conexion = new SqlConnection(
            "Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;" +
            "User ID=sa;Password=Admin123@Strong");

        // ── Datos ─────────────────────────────────────────────────────────────
        private DataTable dtCompleto = new DataTable();   // todos los registros
        private DataTable dtFiltrado = new DataTable();   // vista filtrada

        // ── Filtros por columna (índice → valor elegido) ──────────────────────
        private Dictionary<int, string> filtrosActivos = new Dictionary<int, string>();

        public FrmRepIng01()
        {
            InitializeComponent();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  CARGA DEL FORMULARIO
        // ═════════════════════════════════════════════════════════════════════
        private void FrmRepIng01_Load(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToShortDateString();
            timerHora.Start();
            CargarDatos();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  OBTENER DATOS DE LA BD
        // ═════════════════════════════════════════════════════════════════════
        private void CargarDatos()
        {
            try
            {
                conexion.Open();
                // Reporte de ingresos: tabla Pagos con datos de paciente
                string sql = @"
                    SELECT 
                        p.id_pag         AS [ID Pago],
                        p.ced_pac        AS [Cédula Pac.],
                        p.id_cit         AS [ID Cita],
                        CASE p.id_mpa
                            WHEN 1 THEN 'Efectivo'
                            WHEN 2 THEN 'Tarjeta Crédito'
                            WHEN 3 THEN 'Tarjeta Débito'
                            WHEN 4 THEN 'Transferencia'
                            WHEN 5 THEN 'Seguro'
                            WHEN 6 THEN 'Pago Móvil'
                            ELSE CAST(p.id_mpa AS VARCHAR)
                        END              AS [Método Pago],
                        p.mnt_pag        AS [Monto ($)],
                        p.fec_pag        AS [Fecha Pago]
                    FROM Pagos p
                    ORDER BY p.fec_pag DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                dtCompleto = new DataTable();
                da.Fill(dtCompleto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

            filtrosActivos.Clear();
            AplicarFiltros();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  FILTROS TIPO EXCEL
        // ═════════════════════════════════════════════════════════════════════
        private void AplicarFiltros()
        {
            // Construir expresión de filtro
            string expr = "";
            foreach (var kv in filtrosActivos)
            {
                if (kv.Value == "(Todos)") continue;
                string col = dtCompleto.Columns[kv.Key].ColumnName;
                if (expr != "") expr += " AND ";
                expr += $"[{col}] = '{kv.Value}'";
            }

            DataView dv = new DataView(dtCompleto);
            dv.RowFilter = expr;
            dtFiltrado = dv.ToTable();

            // Refrescar grid
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = dtFiltrado;
            EstilizarGrid();

            // Refrescar gráfico
            ActualizarGrafico();

            // Actualizar total
            ActualizarTotal();

            // Re-pintar botones de filtro en cabecera
            dgvDatos.Invalidate();
        }

        private void EstilizarGrid()
        {
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDatos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Microsoft YaHei", 9f, FontStyle.Bold);
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 255);
            dgvDatos.DefaultCellStyle.Font = new Font("Microsoft YaHei", 8.5f);
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.GridColor = Color.FromArgb(210, 200, 240);
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Resaltar columna Monto
            foreach (DataGridViewColumn col in dgvDatos.Columns)
            {
                if (col.HeaderText == "Monto ($)")
                {
                    col.DefaultCellStyle.ForeColor = Color.Indigo;
                    col.DefaultCellStyle.Font = new Font("Microsoft YaHei", 8.5f, FontStyle.Bold);
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void ActualizarTotal()
        {
            double total = 0;
            foreach (DataRow row in dtFiltrado.Rows)
            {
                if (double.TryParse(row["Monto ($)"].ToString(), out double m))
                    total += m;
            }
            lblTotal.Text = $"Total Ingresos: ${total:N2}   |   Registros: {dtFiltrado.Rows.Count}";
        }

        // ── Menú desplegable de filtro por columna ───────────────────────────
        private void MostrarMenuFiltro(int colIndex, Rectangle headerRect)
        {
            if (dtCompleto.Columns.Count == 0) return;
            string colName = dtCompleto.Columns[colIndex].ColumnName;

            // Valores únicos de esa columna (del dataset completo)
            var valores = dtCompleto.AsEnumerable()
                .Select(r => r[colIndex]?.ToString() ?? "")
                .Distinct()
                .OrderBy(v => v)
                .ToList();

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Microsoft YaHei", 8.5f);

            // Opción "Todos"
            var itemTodos = new ToolStripMenuItem("(Todos)");
            itemTodos.Font = new Font("Microsoft YaHei", 8.5f, FontStyle.Bold);
            itemTodos.Click += (s, e) =>
            {
                filtrosActivos.Remove(colIndex);
                AplicarFiltros();
            };
            menu.Items.Add(itemTodos);
            menu.Items.Add(new ToolStripSeparator());

            foreach (var val in valores)
            {
                string captura = val;
                var item = new ToolStripMenuItem(captura);
                if (filtrosActivos.TryGetValue(colIndex, out string actual) && actual == captura)
                    item.Checked = true;
                item.Click += (s, e) =>
                {
                    filtrosActivos[colIndex] = captura;
                    AplicarFiltros();
                };
                menu.Items.Add(item);
            }

            Point pt = dgvDatos.PointToScreen(
                new Point(headerRect.Left, headerRect.Bottom));
            menu.Show(pt);
        }

        // ── Clic en cabecera → mostrar filtro ────────────────────────────────
        private void dgvDatos_ColumnHeaderMouseClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            Rectangle r = dgvDatos.GetColumnDisplayRectangle(e.ColumnIndex, true);
            MostrarMenuFiltro(e.ColumnIndex, r);
        }

        // ═════════════════════════════════════════════════════════════════════
        //  GRÁFICO DINÁMICO
        // ═════════════════════════════════════════════════════════════════════
        private void ActualizarGrafico()
        {
            chartIngresos.Series.Clear();
            chartIngresos.Titles.Clear();
            chartIngresos.ChartAreas.Clear();

            if (dtFiltrado.Rows.Count == 0) return;

            // Agrupar ingresos por Método de Pago
            var grupos = dtFiltrado.AsEnumerable()
                .GroupBy(r => r["Método Pago"].ToString())
                .Select(g => new
                {
                    Metodo = g.Key,
                    Total = g.Sum(r =>
                        double.TryParse(r["Monto ($)"].ToString(), out double v) ? v : 0)
                })
                .OrderByDescending(g => g.Total)
                .ToList();

            ChartArea area = new ChartArea("AreaPrincipal");
            area.BackColor = Color.Transparent;
            area.AxisX.LabelStyle.Font = new Font("Microsoft YaHei", 8f);
            area.AxisX.LabelStyle.ForeColor = Color.Indigo;
            area.AxisY.LabelStyle.Font = new Font("Microsoft YaHei", 8f);
            area.AxisY.LabelStyle.ForeColor = Color.Indigo;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 210, 250);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 210, 250);
            area.BorderColor = Color.MediumPurple;
            area.BorderWidth = 1;
            chartIngresos.ChartAreas.Add(area);

            // Serie de barras
            Series serie = new Series("Ingresos por Método");
            serie.ChartType = SeriesChartType.Bar;
            serie.ChartArea = "AreaPrincipal";
            serie.IsValueShownAsLabel = true;
            serie.Font = new Font("Microsoft YaHei", 8f, FontStyle.Bold);
            serie.LabelForeColor = Color.Indigo;

            Color[] colores = {
                Color.FromArgb(147, 112, 219),
                Color.FromArgb(75, 0, 130),
                Color.FromArgb(186, 85, 211),
                Color.FromArgb(218, 112, 214)
            };

            for (int i = 0; i < grupos.Count; i++)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueY(grupos[i].Total);
                dp.AxisLabel = grupos[i].Metodo;
                // Formato: Nombre $Valor (#Porcentaje)
                dp.Label = $"{grupos[i].Metodo}\n${grupos[i].Total:N0} (#PERCENT)";
                dp.Color = colores[i % colores.Length];
                
                // Si es pastel o dona, poner etiquetas fuera con líneas
                if (ObtenerTipoGrafico() == SeriesChartType.Pie || ObtenerTipoGrafico() == SeriesChartType.Doughnut)
                {
                    dp["PieLabelStyle"] = "Outside";
                    dp["PieLineColor"] = "Indigo";
                }
                
                serie.Points.Add(dp);
            }
            chartIngresos.Series.Add(serie);

            // Título
            Title titulo = new Title("Ingresos por Método de Pago");
            titulo.Font = new Font("Microsoft YaHei", 10f, FontStyle.Bold);
            titulo.ForeColor = Color.Indigo;
            chartIngresos.Titles.Add(titulo);

            chartIngresos.BackColor = Color.Transparent;
        }

        // ═════════════════════════════════════════════════════════════════════
        //  TIMER HORA
        // ═════════════════════════════════════════════════════════════════════
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  BOTÓN RETORNAR
        // ═════════════════════════════════════════════════════════════════════
        private void btnRtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  BOTÓN LIMPIAR FILTROS
        // ═════════════════════════════════════════════════════════════════════
        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            filtrosActivos.Clear();
            AplicarFiltros();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  CAMBIO TIPO GRÁFICO
        // ═════════════════════════════════════════════════════════════════════
        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
            if (chartIngresos.Series.Count > 0)
            {
                SeriesChartType tipo = ObtenerTipoGrafico();
                chartIngresos.Series[0].ChartType = tipo;
                if (tipo == SeriesChartType.Pie || tipo == SeriesChartType.Doughnut)
                {
                    chartIngresos.Series[0]["PieLabelStyle"] = "Outside";
                    foreach (DataPoint dp in chartIngresos.Series[0].Points)
                        dp.Label = dp.AxisLabel + "\n" + dp.Label;
                }
            }
        }
        private SeriesChartType ObtenerTipoGrafico()
        {
            switch (cmbTipoGrafico.SelectedIndex)
            {
                case 1: return SeriesChartType.Column;
                case 2: return SeriesChartType.Pie;
                case 3: return SeriesChartType.Doughnut;
                default: return SeriesChartType.Bar;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ReportUtils.ExportToCSV(dgvDatos);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReportUtils.PrintDataGridView(dgvDatos, "Reporte de Ingresos", chartIngresos);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ReportUtils.ExportToPDF(dgvDatos, "Reporte de Ingresos", chartIngresos);
        }
    }
}
