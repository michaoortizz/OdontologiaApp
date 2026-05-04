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
    public partial class FrmRepTrat03 : Form
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

        // Mapas de ID → texto (para tipo y servicio)
        private readonly Dictionary<string, string> mapaTipo = new Dictionary<string, string>
        {
            { "1", "Preventivo" }, { "2", "Restaurativo" }, { "3", "Estético" }
        };
        private readonly Dictionary<string, string> mapaServicio = new Dictionary<string, string>
        {
            { "1", "Limpieza" }, { "2", "Extracción" }, { "3", "Ortodoncia" }
        };

        public FrmRepTrat03()
        {
            InitializeComponent();
        }

        // ═════════════════════════════════════════════════════════════════════
        //  CARGA
        // ═════════════════════════════════════════════════════════════════════
        private void FrmRepTrat03_Load(object sender, EventArgs e)
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
                // Tratamientos: id_tra, ced_pac, id_doc, id_ttr, id_srv,
                //               dsc_tra, cst_tra, fec_ini_tra, fec_fin_tra,
                //               nom_tra, dur_tra, id_cit
                string sql = @"
                    SELECT
                        id_tra              AS [ID Tratamiento],
                        ced_pac             AS [Cédula Pac.],
                        id_doc              AS [ID Doctor],
                        CASE id_ttr
                            WHEN 1 THEN 'Preventivo'
                            WHEN 2 THEN 'Restaurativo'
                            WHEN 3 THEN 'Estético'
                            ELSE CAST(id_ttr AS VARCHAR)
                        END                 AS [Tipo],
                        CASE id_srv
                            WHEN 1 THEN 'Limpieza'
                            WHEN 2 THEN 'Extracción'
                            WHEN 3 THEN 'Ortodoncia'
                            ELSE CAST(id_srv AS VARCHAR)
                        END                 AS [Servicio],
                        dsc_tra             AS [Descripción],
                        cst_tra             AS [Costo ($)],
                        fec_ini_tra         AS [Fecha Inicio],
                        fec_fin_tra         AS [Fecha Fin],
                        nom_tra             AS [Nombre],
                        dur_tra             AS [Duración],
                        id_cit              AS [ID Cita]
                    FROM Tratamientos
                    ORDER BY fec_ini_tra DESC";

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
                // Si el valor contiene apostrofe, escapar
                string val = kv.Value.Replace("'", "''");
                expr += $"[{col}] = '{val}'";
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
                if (col.HeaderText == "Costo ($)")
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
            foreach (DataRow row in dtFiltrado.Rows)
                if (double.TryParse(row["Costo ($)"].ToString(), out double c)) costoTotal += c;

            lblResumen.Text = $"Tratamientos: {total}   |   Costo Total: ${costoTotal:N2}";
        }

        // ── Menú filtro ───────────────────────────────────────────────────────
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
        //  GRÁFICO: Costo total por Tipo de Tratamiento
        // ═════════════════════════════════════════════════════════════════════
        private void ActualizarGrafico()
        {
            chartTratamientos.Series.Clear();
            chartTratamientos.Titles.Clear();
            chartTratamientos.ChartAreas.Clear();

            if (dtFiltrado.Rows.Count == 0) return;

            // Agrupación según tipo de vista seleccionada
            string agrupacion = cmbAgrupacion.SelectedIndex == 1 ? "Servicio" : "Tipo";

            var grupos = dtFiltrado.AsEnumerable()
                .GroupBy(r => r[agrupacion].ToString())
                .Select(g => new
                {
                    Nombre = g.Key == "" ? "Sin clasificar" : g.Key,
                    CostoTotal = g.Sum(r =>
                        double.TryParse(r["Costo ($)"].ToString(), out double c) ? c : 0),
                    Cantidad = g.Count()
                })
                .OrderByDescending(g => g.CostoTotal)
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
            chartTratamientos.ChartAreas.Add(area);

            Series serie = new Series("Costo por " + agrupacion);
            serie.ChartType = ObtenerTipoGrafico();
            serie.ChartArea = "AreaPrincipal";
            serie.IsValueShownAsLabel = true;
            serie.Font = new Font("Microsoft YaHei", 8f, FontStyle.Bold);
            serie.LabelForeColor = Color.Indigo;

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
                dp.SetValueY(grupos[i].CostoTotal);
                dp.AxisLabel = grupos[i].Nombre;
                // Formato: Nombre $Costo (#Porcentaje)
                dp.Label = $"{grupos[i].Nombre}\n${grupos[i].CostoTotal:N0} (#PERCENT)";
                dp.Color = colores[i % colores.Length];
                dp.ToolTip = $"{grupos[i].Nombre}: ${grupos[i].CostoTotal:N2} ({grupos[i].Cantidad} tratamientos)";
                
                // Si es pastel o dona, poner etiquetas fuera con líneas
                if (ObtenerTipoGrafico() == SeriesChartType.Pie || ObtenerTipoGrafico() == SeriesChartType.Doughnut)
                {
                    dp["PieLabelStyle"] = "Outside";
                    dp["PieLineColor"] = "Indigo";
                }
                
                serie.Points.Add(dp);
            }
            chartTratamientos.Series.Add(serie);

            Title titulo = new Title($"Costo Total por {agrupacion} de Tratamiento");
            titulo.Font = new Font("Microsoft YaHei", 10f, FontStyle.Bold);
            titulo.ForeColor = Color.Indigo;
            chartTratamientos.Titles.Add(titulo);
            chartTratamientos.BackColor = Color.Transparent;
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
            ReportUtils.PrintDataGridView(dgvDatos, "Reporte de Tratamientos", chartTratamientos);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ReportUtils.ExportToPDF(dgvDatos, "Reporte de Tratamientos", chartTratamientos);
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
            if (chartTratamientos.Series.Count > 0)
            {
                chartTratamientos.Series[0].ChartType = ObtenerTipoGrafico();
                if (ObtenerTipoGrafico() == SeriesChartType.Pie
                    || ObtenerTipoGrafico() == SeriesChartType.Doughnut)
                    chartTratamientos.Series[0]["PieLabelStyle"] = "Outside";
            }
        }

        private void cmbAgrupacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }
    }
}
