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
    public partial class FrmRepMat02 : Form
    {
        // ── Conexión ──────────────────────────────────────────────────────────
        private readonly SqlConnection conexion = new SqlConnection(
            "Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;" +
            "User ID=sa;Password=Admin123@Strong");

        // ── Datos ─────────────────────────────────────────────────────────────
        private DataTable dtCompleto = new DataTable();
        private DataTable dtFiltrado = new DataTable();

        // ── Filtros por columna ───────────────────────────────────────────────
        private Dictionary<int, string> filtrosActivos = new Dictionary<int, string>();

        public FrmRepMat02()
        {
            InitializeComponent();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  CARGA
        // ═════════════════════════════════════════════════════════════════════
        private void FrmRepMat02_Load(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToShortDateString();
            timerHora.Start();
            CargarDatos();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  DATOS DE LA BD
        // ═════════════════════════════════════════════════════════════════════
        private void CargarDatos()
        {
            try
            {
                conexion.Open();
                // Columnas: id_mat, nom_mat, dsc_mat, cnt_mat, cst_mat, tip_mat, id_prv
                string sql = @"
                    SELECT 
                        id_mat   AS [ID Material],
                        nom_mat  AS [Nombre],
                        dsc_mat  AS [Descripción],
                        cnt_mat  AS [Cantidad],
                        cst_mat  AS [Costo ($)],
                        tip_mat  AS [Tipo],
                        id_prv   AS [ID Proveedor]
                    FROM Materiales
                    ORDER BY nom_mat";

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
        //  FILTROS
        // ═════════════════════════════════════════════════════════════════════
        private void AplicarFiltros()
        {
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

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = dtFiltrado;
            EstilizarGrid();
            ActualizarGrafico();
            ActualizarResumen();
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

            foreach (DataGridViewColumn col in dgvDatos.Columns)
            {
                if (col.HeaderText == "Costo ($)" || col.HeaderText == "Cantidad")
                {
                    col.DefaultCellStyle.ForeColor = Color.Indigo;
                    col.DefaultCellStyle.Font = new Font("Microsoft YaHei", 8.5f, FontStyle.Bold);
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void ActualizarResumen()
        {
            int total = dtFiltrado.Rows.Count;
            double costoTotal = 0;
            int cantTotal = 0;
            foreach (DataRow row in dtFiltrado.Rows)
            {
                if (double.TryParse(row["Costo ($)"].ToString(), out double c)) costoTotal += c;
                if (int.TryParse(row["Cantidad"].ToString(), out int q)) cantTotal += q;
            }
            lblResumen.Text = $"Materiales: {total}   |   Cantidad Total: {cantTotal}   |   Valor Total: ${costoTotal:N2}";
        }

        // ── Menú filtro por columna ───────────────────────────────────────────
        private void MostrarMenuFiltro(int colIndex, Rectangle headerRect)
        {
            if (dtCompleto.Columns.Count == 0) return;

            var valores = dtCompleto.AsEnumerable()
                .Select(r => r[colIndex]?.ToString() ?? "")
                .Distinct().OrderBy(v => v).ToList();

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Microsoft YaHei", 8.5f);

            var itemTodos = new ToolStripMenuItem("(Todos)");
            itemTodos.Font = new Font("Microsoft YaHei", 8.5f, FontStyle.Bold);
            itemTodos.Click += (s, e) => { filtrosActivos.Remove(colIndex); AplicarFiltros(); };
            menu.Items.Add(itemTodos);
            menu.Items.Add(new ToolStripSeparator());

            foreach (var val in valores)
            {
                string cap = val;
                var item = new ToolStripMenuItem(cap);
                if (filtrosActivos.TryGetValue(colIndex, out string act) && act == cap)
                    item.Checked = true;
                item.Click += (s, e) => { filtrosActivos[colIndex] = cap; AplicarFiltros(); };
                menu.Items.Add(item);
            }

            Point pt = dgvDatos.PointToScreen(new Point(headerRect.Left, headerRect.Bottom));
            menu.Show(pt);
        }

        private void dgvDatos_ColumnHeaderMouseClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            Rectangle r = dgvDatos.GetColumnDisplayRectangle(e.ColumnIndex, true);
            MostrarMenuFiltro(e.ColumnIndex, r);
        }

        // ═════════════════════════════════════════════════════════════════════
        //  GRÁFICO: Stock por Tipo de material
        // ═════════════════════════════════════════════════════════════════════
        private void ActualizarGrafico()
        {
            chartMateriales.Series.Clear();
            chartMateriales.Titles.Clear();
            chartMateriales.ChartAreas.Clear();

            if (dtFiltrado.Rows.Count == 0) return;

            var grupos = dtFiltrado.AsEnumerable()
                .GroupBy(r => r["Tipo"].ToString())
                .Select(g => new
                {
                    Tipo = g.Key == "" ? "Sin Tipo" : g.Key,
                    Cantidad = g.Sum(r =>
                        int.TryParse(r["Cantidad"].ToString(), out int q) ? q : 0),
                    Costo = g.Sum(r =>
                        double.TryParse(r["Costo ($)"].ToString(), out double c) ? c : 0)
                })
                .OrderByDescending(g => g.Cantidad)
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
            chartMateriales.ChartAreas.Add(area);

            // Serie cantidad
            Series serieQ = new Series("Cantidad en Stock");
            serieQ.ChartType = ObtenerTipoGrafico();
            serieQ.ChartArea = "AreaPrincipal";
            serieQ.IsValueShownAsLabel = true;
            serieQ.Font = new Font("Microsoft YaHei", 8f, FontStyle.Bold);
            serieQ.LabelForeColor = Color.Indigo;

            Color[] colores = {
                Color.FromArgb(147, 112, 219),
                Color.FromArgb(75, 0, 130),
                Color.FromArgb(186, 85, 211),
                Color.FromArgb(218, 112, 214),
                Color.FromArgb(100, 149, 237)
            };

            for (int i = 0; i < grupos.Count; i++)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueY(grupos[i].Cantidad);
                dp.AxisLabel = grupos[i].Tipo;
                // Formato: Tipo Cantidad (#Porcentaje)
                dp.Label = $"{grupos[i].Tipo}\n{grupos[i].Cantidad} uds (#PERCENT)";
                dp.Color = colores[i % colores.Length];
                
                // Si es pastel o dona, poner etiquetas fuera con líneas
                if (ObtenerTipoGrafico() == SeriesChartType.Pie || ObtenerTipoGrafico() == SeriesChartType.Doughnut)
                {
                    dp["PieLabelStyle"] = "Outside";
                    dp["PieLineColor"] = "Indigo";
                }
                
                serieQ.Points.Add(dp);
            }
            chartMateriales.Series.Add(serieQ);

            Title titulo = new Title("Stock por Tipo de Material");
            titulo.Font = new Font("Microsoft YaHei", 10f, FontStyle.Bold);
            titulo.ForeColor = Color.Indigo;
            chartMateriales.Titles.Add(titulo);
            chartMateriales.BackColor = Color.Transparent;
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
            ReportUtils.PrintDataGridView(dgvDatos, "Reporte de Inventario de Materiales", chartMateriales);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ReportUtils.ExportToPDF(dgvDatos, "Reporte de Inventario de Materiales", chartMateriales);
        }

        // ═════════════════════════════════════════════════════════════════════
        //  EVENTOS
        // ═════════════════════════════════════════════════════════════════════
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            filtrosActivos.Clear();
            AplicarFiltros();
        }

        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
            if (chartMateriales.Series.Count > 0)
            {
                SeriesChartType tipo = ObtenerTipoGrafico();
                chartMateriales.Series[0].ChartType = tipo;
                if (tipo == SeriesChartType.Pie || tipo == SeriesChartType.Doughnut)
                    chartMateriales.Series[0]["PieLabelStyle"] = "Outside";
            }
        }

        private void lblResumen_Click(object sender, EventArgs e)
        {

        }
    }
}
