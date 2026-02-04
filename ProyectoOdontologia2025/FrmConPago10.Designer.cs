namespace ProyectoOdontologia2025
{
    partial class FrmConPago10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbCriterio = new System.Windows.Forms.GroupBox();
            this.btnRtn = new System.Windows.Forms.Button();
            this.rdbCed = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbMonto = new System.Windows.Forms.RadioButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.rdbEmp = new System.Windows.Forms.RadioButton();
            this.rdbFechaPag = new System.Windows.Forms.RadioButton();
            this.rdbCot = new System.Windows.Forms.RadioButton();
            this.rdbFormaPago = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblEnca = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbCriterio.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCriterio
            // 
            this.gpbCriterio.BackColor = System.Drawing.Color.Lavender;
            this.gpbCriterio.Controls.Add(this.btnRtn);
            this.gpbCriterio.Controls.Add(this.rdbCed);
            this.gpbCriterio.Controls.Add(this.txtBusqueda);
            this.gpbCriterio.Controls.Add(this.rdbMonto);
            this.gpbCriterio.Controls.Add(this.lblBusqueda);
            this.gpbCriterio.Controls.Add(this.rdbEmp);
            this.gpbCriterio.Controls.Add(this.rdbFechaPag);
            this.gpbCriterio.Controls.Add(this.rdbCot);
            this.gpbCriterio.Controls.Add(this.rdbFormaPago);
            this.gpbCriterio.Controls.Add(this.rdbId);
            this.gpbCriterio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCriterio.Location = new System.Drawing.Point(23, 171);
            this.gpbCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.gpbCriterio.Name = "gpbCriterio";
            this.gpbCriterio.Padding = new System.Windows.Forms.Padding(2);
            this.gpbCriterio.Size = new System.Drawing.Size(689, 151);
            this.gpbCriterio.TabIndex = 40;
            this.gpbCriterio.TabStop = false;
            this.gpbCriterio.Text = "Criterios de busqueda";
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Location = new System.Drawing.Point(507, 103);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(156, 35);
            this.btnRtn.TabIndex = 46;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            // 
            // rdbCed
            // 
            this.rdbCed.AutoSize = true;
            this.rdbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCed.Location = new System.Drawing.Point(106, 69);
            this.rdbCed.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCed.Name = "rdbCed";
            this.rdbCed.Size = new System.Drawing.Size(77, 19);
            this.rdbCed.TabIndex = 15;
            this.rdbCed.TabStop = true;
            this.rdbCed.Text = "Id Cédula";
            this.rdbCed.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(267, 109);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 22);
            this.txtBusqueda.TabIndex = 45;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // rdbMonto
            // 
            this.rdbMonto.AutoSize = true;
            this.rdbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonto.Location = new System.Drawing.Point(515, 30);
            this.rdbMonto.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMonto.Name = "rdbMonto";
            this.rdbMonto.Size = new System.Drawing.Size(60, 19);
            this.rdbMonto.TabIndex = 11;
            this.rdbMonto.TabStop = true;
            this.rdbMonto.Text = "Monto";
            this.rdbMonto.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(31, 109);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(196, 19);
            this.lblBusqueda.TabIndex = 44;
            this.lblBusqueda.Text = "Digite criterio de búsqueda:";
            // 
            // rdbEmp
            // 
            this.rdbEmp.AutoSize = true;
            this.rdbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmp.Location = new System.Drawing.Point(234, 69);
            this.rdbEmp.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEmp.Name = "rdbEmp";
            this.rdbEmp.Size = new System.Drawing.Size(95, 19);
            this.rdbEmp.TabIndex = 4;
            this.rdbEmp.TabStop = true;
            this.rdbEmp.Text = "Id Empleado";
            this.rdbEmp.UseVisualStyleBackColor = true;
            // 
            // rdbFechaPag
            // 
            this.rdbFechaPag.AutoSize = true;
            this.rdbFechaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFechaPag.Location = new System.Drawing.Point(386, 30);
            this.rdbFechaPag.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFechaPag.Name = "rdbFechaPag";
            this.rdbFechaPag.Size = new System.Drawing.Size(91, 19);
            this.rdbFechaPag.TabIndex = 3;
            this.rdbFechaPag.TabStop = true;
            this.rdbFechaPag.Text = "Fecha Pago";
            this.rdbFechaPag.UseVisualStyleBackColor = true;
            // 
            // rdbCot
            // 
            this.rdbCot.AutoSize = true;
            this.rdbCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCot.Location = new System.Drawing.Point(265, 30);
            this.rdbCot.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCot.Name = "rdbCot";
            this.rdbCot.Size = new System.Drawing.Size(95, 19);
            this.rdbCot.TabIndex = 2;
            this.rdbCot.TabStop = true;
            this.rdbCot.Text = "Id Cotización";
            this.rdbCot.UseVisualStyleBackColor = true;
            // 
            // rdbFormaPago
            // 
            this.rdbFormaPago.AutoSize = true;
            this.rdbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFormaPago.Location = new System.Drawing.Point(148, 30);
            this.rdbFormaPago.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFormaPago.Name = "rdbFormaPago";
            this.rdbFormaPago.Size = new System.Drawing.Size(93, 19);
            this.rdbFormaPago.TabIndex = 1;
            this.rdbFormaPago.TabStop = true;
            this.rdbFormaPago.Text = "Forma Pago";
            this.rdbFormaPago.UseVisualStyleBackColor = true;
            this.rdbFormaPago.CheckedChanged += new System.EventHandler(this.rdbformap_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId.Location = new System.Drawing.Point(49, 30);
            this.rdbId.Margin = new System.Windows.Forms.Padding(2);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(67, 19);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Pago";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Interval = 50;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.Lavender;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 41;
            this.gpbTitulo.TabStop = false;
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.Location = new System.Drawing.Point(13, 45);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(164, 19);
            this.lblnom1.TabIndex = 1;
            this.lblnom1.Text = "Politécnico Las Mercedes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(7, 21);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(183, 19);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Consultorio Odontológico";
            // 
            // gpbFecha
            // 
            this.gpbFecha.BackColor = System.Drawing.Color.Lavender;
            this.gpbFecha.Controls.Add(this.lblhora2);
            this.gpbFecha.Controls.Add(this.lblfecha2);
            this.gpbFecha.Controls.Add(this.lblhora);
            this.gpbFecha.Controls.Add(this.lblfecha);
            this.gpbFecha.Location = new System.Drawing.Point(506, 12);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(206, 78);
            this.gpbFecha.TabIndex = 42;
            this.gpbFecha.TabStop = false;
            // 
            // lblhora2
            // 
            this.lblhora2.BackColor = System.Drawing.Color.White;
            this.lblhora2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora2.Location = new System.Drawing.Point(116, 47);
            this.lblhora2.Name = "lblhora2";
            this.lblhora2.Size = new System.Drawing.Size(77, 19);
            this.lblhora2.TabIndex = 3;
            // 
            // lblfecha2
            // 
            this.lblfecha2.BackColor = System.Drawing.Color.White;
            this.lblfecha2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha2.Location = new System.Drawing.Point(116, 16);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(77, 19);
            this.lblfecha2.TabIndex = 2;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(20, 45);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(42, 19);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(20, 16);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 19);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha:";
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(254, 108);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(217, 28);
            this.lblEnca.TabIndex = 30;
            this.lblEnca.Text = "Consultas de Pagos";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvDatos);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(23, 347);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(689, 172);
            this.gpbResultado.TabIndex = 43;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado de búsqueda";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(26, 27);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(640, 135);
            this.dgvDatos.TabIndex = 0;
            // 
            // FrmConPago10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(741, 530);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbCriterio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConPago10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Consulta de Pagos";
            this.Activated += new System.EventHandler(this.FrmConPago10_Activated);
            this.Load += new System.EventHandler(this.FrmConPago10_Load);
            this.gpbCriterio.ResumeLayout(false);
            this.gpbCriterio.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCriterio;
        private System.Windows.Forms.RadioButton rdbMonto;
        private System.Windows.Forms.RadioButton rdbEmp;
        private System.Windows.Forms.RadioButton rdbFechaPag;
        private System.Windows.Forms.RadioButton rdbCot;
        private System.Windows.Forms.RadioButton rdbFormaPago;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbCed;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnRtn;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}