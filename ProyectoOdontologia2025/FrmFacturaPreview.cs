using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class FrmFacturaPreview : Form
    {
        private int idPago;
        private string connectionString = "Data Source=132.145.163.113,1433;Initial Catalog=OdontologiaBD;User ID=sa;Password=Admin123@Strong";
        
        // Datos de la factura
        private string numFac;
        private string fechaEmis;
        private string paciente;
        private string cedula;
        private decimal total;
        private List<FacturaDetalle> detalles = new List<FacturaDetalle>();

        public FrmFacturaPreview(int idPago)
        {
            InitializeComponent();
            this.idPago = idPago;
        }

        private void FrmFacturaPreview_Load(object sender, EventArgs e)
        {
            CargarDatosFactura();
            MostrarVistaPrevia();
        }

        private void CargarDatosFactura()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // 1. Obtener datos del pago y paciente
                    string queryPago = @"
                        SELECT p.id_pag, p.ced_pac, p.id_cit, p.mnt_pag, p.fec_pag,
                               pa.nom_pac, pa.ape_pac
                        FROM Pagos p
                        JOIN Pacientes pa ON p.ced_pac = pa.ced_pac
                        WHERE p.id_pag = @idPago";
                    
                    SqlCommand cmdPago = new SqlCommand(queryPago, conn);
                    cmdPago.Parameters.AddWithValue("@idPago", idPago);
                    
                    SqlDataReader reader = cmdPago.ExecuteReader();
                    int idCita = 0;
                    if (reader.Read())
                    {
                        cedula = reader["ced_pac"].ToString();
                        paciente = reader["nom_pac"].ToString() + " " + reader["ape_pac"].ToString();
                        total = Convert.ToDecimal(reader["mnt_pag"]);
                        idCita = Convert.ToInt32(reader["id_cit"]);
                        fechaEmis = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    }
                    reader.Close();

                    // 2. Obtener servicios de la cita
                    string queryServicios = @"
                        SELECT s.id_srv, s.nom_srv, s.cst_srv
                        FROM Citas_Servicios cs
                        JOIN Servicios s ON cs.id_srv = s.id_srv
                        WHERE cs.id_cit = @idCita";
                    
                    SqlCommand cmdSrv = new SqlCommand(queryServicios, conn);
                    cmdSrv.Parameters.AddWithValue("@idCita", idCita);
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSrv);
                    DataTable dtSrv = new DataTable();
                    adapter.Fill(dtSrv);

                    foreach (DataRow row in dtSrv.Rows)
                    {
                        detalles.Add(new FacturaDetalle
                        {
                            IdSrv = Convert.ToInt32(row["id_srv"]),
                            Nombre = row["nom_srv"].ToString(),
                            Precio = Convert.ToDecimal(row["cst_srv"]),
                            Cantidad = 1,
                            Subtotal = Convert.ToDecimal(row["cst_srv"])
                        });
                    }

                    // 3. Generar número de factura (temporal si no existe en DB)
                    // Buscamos si ya existe
                    string queryFacExist = "SELECT num_fac FROM Facturas WHERE id_pag = @idPago";
                    SqlCommand cmdExist = new SqlCommand(queryFacExist, conn);
                    cmdExist.Parameters.AddWithValue("@idPago", idPago);
                    object existingNum = cmdExist.ExecuteScalar();

                    if (existingNum != null)
                    {
                        numFac = existingNum.ToString();
                        btnImprimir.Text = "Re-imprimir";
                    }
                    else
                    {
                        // Generar uno nuevo correlativo
                        string queryMax = "SELECT ISNULL(MAX(id_fac), 0) + 1 FROM Facturas";
                        SqlCommand cmdMax = new SqlCommand(queryMax, conn);
                        int nextId = (int)cmdMax.ExecuteScalar();
                        numFac = "FAC-" + nextId.ToString("D6");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void MostrarVistaPrevia()
        {
            rtbTicket.Clear();
            rtbTicket.SelectionAlignment = HorizontalAlignment.Center;
            rtbTicket.AppendText("CONSULTORIO ODONTOLÓGICO\n");
            rtbTicket.AppendText("Politécnico Las Mercedes\n");
            rtbTicket.AppendText("RNC: 123-45678-9\n");
            rtbTicket.AppendText("Calle Principal #123, Sto Dgo\n");
            rtbTicket.AppendText("Tel: (809) 555-0199\n");
            rtbTicket.AppendText("--------------------------------\n");
            rtbTicket.SelectionAlignment = HorizontalAlignment.Left;
            rtbTicket.AppendText($"Factura: {numFac}\n");
            rtbTicket.AppendText($"Fecha: {fechaEmis}\n");
            rtbTicket.AppendText($"Cliente: {paciente}\n");
            rtbTicket.AppendText($"Cédula: {cedula}\n");
            rtbTicket.AppendText("--------------------------------\n");
            rtbTicket.AppendText(string.Format("{0,-18} {1,5} {2,7}\n", "Descripción", "Cant", "Total"));
            rtbTicket.AppendText("--------------------------------\n");

            foreach (var det in detalles)
            {
                string desc = det.Nombre.Length > 18 ? det.Nombre.Substring(0, 15) + "..." : det.Nombre;
                rtbTicket.AppendText(string.Format("{0,-18} {1,5} {2,7:N2}\n", desc, det.Cantidad, det.Subtotal));
            }

            rtbTicket.AppendText("--------------------------------\n");
            rtbTicket.SelectionAlignment = HorizontalAlignment.Right;
            rtbTicket.AppendText($"SUBTOTAL: {total:N2}\n");
            rtbTicket.AppendText($"ITBIS (0%): 0.00\n");
            rtbTicket.AppendText($"TOTAL: {total:N2}\n");
            rtbTicket.AppendText("--------------------------------\n");
            rtbTicket.SelectionAlignment = HorizontalAlignment.Center;
            rtbTicket.AppendText("\n¡Gracias por su visita!\n");
            rtbTicket.AppendText("Cuidamos tu sonrisa.\n");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (GuardarFacturaEnBaseDeDatos())
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(PrintTicket);
                
                // Configuración para impresora térmica (80mm aprox)
                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 285, 1000); 
                
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                
                if (ppd.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
                
                this.Close();
            }
        }

        private bool GuardarFacturaEnBaseDeDatos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // Verificar si ya existe
                    string checkQuery = "SELECT COUNT(*) FROM Facturas WHERE id_pag = @idPago";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@idPago", idPago);
                    int count = (int)cmdCheck.ExecuteScalar();
                    
                    if (count > 0) return true; // Ya está guardada

                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        string queryFac = @"
                            INSERT INTO Facturas (id_pag, num_fac, fec_emis_fac, imp_fac, ttl_fac)
                            OUTPUT INSERTED.id_fac
                            VALUES (@idPago, @numFac, @fec, @imp, @ttl)";
                        
                        SqlCommand cmdFac = new SqlCommand(queryFac, conn, trans);
                        cmdFac.Parameters.AddWithValue("@idPago", idPago);
                        cmdFac.Parameters.AddWithValue("@numFac", numFac);
                        cmdFac.Parameters.AddWithValue("@fec", DateTime.Now);
                        cmdFac.Parameters.AddWithValue("@imp", 0); // Ajustar si hay impuestos
                        cmdFac.Parameters.AddWithValue("@ttl", total);
                        
                        int idFac = (int)cmdFac.ExecuteScalar();

                        foreach (var det in detalles)
                        {
                            string queryDet = @"
                                INSERT INTO Detalle_Factura (id_fac, id_srv, cant, precio, subtotal)
                                VALUES (@idFac, @idSrv, @cant, @precio, @sub)";
                            
                            SqlCommand cmdDet = new SqlCommand(queryDet, conn, trans);
                            cmdDet.Parameters.AddWithValue("@idFac", idFac);
                            cmdDet.Parameters.AddWithValue("@idSrv", det.IdSrv);
                            cmdDet.Parameters.AddWithValue("@cant", det.Cantidad);
                            cmdDet.Parameters.AddWithValue("@precio", det.Precio);
                            cmdDet.Parameters.AddWithValue("@sub", det.Subtotal);
                            cmdDet.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar factura: " + ex.Message);
                return false;
            }
        }

        private void PrintTicket(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Courier New", 10, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 9);
            float y = 10;
            float width = 280;

            StringFormat center = new StringFormat() { Alignment = StringAlignment.Center };
            
            g.DrawString("CONSULTORIO ODONTOLÓGICO", fontTitle, Brushes.Black, new RectangleF(0, y, width, 20), center); y += 15;
            g.DrawString("Politécnico Las Mercedes", fontNormal, Brushes.Black, new RectangleF(0, y, width, 20), center); y += 15;
            g.DrawString("RNC: 123-45678-9", fontNormal, Brushes.Black, new RectangleF(0, y, width, 20), center); y += 15;
            g.DrawString("Tel: (809) 555-0199", fontNormal, Brushes.Black, new RectangleF(0, y, width, 20), center); y += 20;

            g.DrawString("--------------------------------", fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString($"Factura: {numFac}", fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString($"Fecha: {fechaEmis}", fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString($"Paciente: {paciente}", fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString("--------------------------------", fontNormal, Brushes.Black, 0, y); y += 15;

            g.DrawString(string.Format("{0,-15} {1,4} {2,8}", "Servicio", "Cant", "Total"), fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString("--------------------------------", fontNormal, Brushes.Black, 0, y); y += 15;

            foreach (var det in detalles)
            {
                string name = det.Nombre.Length > 15 ? det.Nombre.Substring(0, 14) : det.Nombre;
                g.DrawString(string.Format("{0,-15} {1,4} {2,8:N2}", name, det.Cantidad, det.Subtotal), fontNormal, Brushes.Black, 0, y); y += 15;
            }

            g.DrawString("--------------------------------", fontNormal, Brushes.Black, 0, y); y += 15;
            g.DrawString($"TOTAL RD$: {total:N2}", fontTitle, Brushes.Black, new RectangleF(0, y, width, 20), new StringFormat() { Alignment = StringAlignment.Far }); y += 30;

            g.DrawString("¡Gracias por preferirnos!", fontNormal, Brushes.Black, new RectangleF(0, y, width, 20), center); y += 15;
            g.DrawString("Sonreír es salud.", fontNormal, Brushes.Black, new RectangleF(0, y, width, 20), center);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FacturaDetalle
    {
        public int IdSrv { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
