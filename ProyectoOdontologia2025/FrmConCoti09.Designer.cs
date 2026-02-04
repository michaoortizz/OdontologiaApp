namespace ProyectoOdontologia2025
{
    partial class FrmConCoti09
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
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbCriterio = new System.Windows.Forms.GroupBox();
            this.btnRtn = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.rdbEstado = new System.Windows.Forms.RadioButton();
            this.rdbBalance = new System.Windows.Forms.RadioButton();
            this.rdbCant = new System.Windows.Forms.RadioButton();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbEmp = new System.Windows.Forms.RadioButton();
            this.rdbMonto = new System.Windows.Forms.RadioButton();
            this.rdbCedula = new System.Windows.Forms.RadioButton();
            this.rdbDiag = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.lblEnca = new System.Windows.Forms.Label();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbCriterio.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvDatos);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(23, 344);
            this.gpbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Size = new System.Drawing.Size(689, 180);
            this.gpbResultado.TabIndex = 36;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado de búsqueda";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 26);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(640, 135);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // gpbCriterio
            // 
            this.gpbCriterio.BackColor = System.Drawing.Color.Lavender;
            this.gpbCriterio.Controls.Add(this.btnRtn);
            this.gpbCriterio.Controls.Add(this.txtBusqueda);
            this.gpbCriterio.Controls.Add(this.lblBusqueda);
            this.gpbCriterio.Controls.Add(this.rdbEstado);
            this.gpbCriterio.Controls.Add(this.rdbBalance);
            this.gpbCriterio.Controls.Add(this.rdbCant);
            this.gpbCriterio.Controls.Add(this.rdbDesc);
            this.gpbCriterio.Controls.Add(this.rdbEmp);
            this.gpbCriterio.Controls.Add(this.rdbMonto);
            this.gpbCriterio.Controls.Add(this.rdbCedula);
            this.gpbCriterio.Controls.Add(this.rdbDiag);
            this.gpbCriterio.Controls.Add(this.rdbId);
            this.gpbCriterio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCriterio.Location = new System.Drawing.Point(23, 166);
            this.gpbCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.gpbCriterio.Name = "gpbCriterio";
            this.gpbCriterio.Padding = new System.Windows.Forms.Padding(2);
            this.gpbCriterio.Size = new System.Drawing.Size(689, 152);
            this.gpbCriterio.TabIndex = 35;
            this.gpbCriterio.TabStop = false;
            this.gpbCriterio.Text = "Criterios de busqueda";
            this.gpbCriterio.Enter += new System.EventHandler(this.gpbCriterio_Enter);
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Location = new System.Drawing.Point(496, 102);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(156, 35);
            this.btnRtn.TabIndex = 40;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(256, 113);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 22);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(20, 113);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(196, 19);
            this.lblBusqueda.TabIndex = 15;
            this.lblBusqueda.Text = "Digite criterio de búsqueda:";
            // 
            // rdbEstado
            // 
            this.rdbEstado.AutoSize = true;
            this.rdbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEstado.Location = new System.Drawing.Point(488, 66);
            this.rdbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEstado.Name = "rdbEstado";
            this.rdbEstado.Size = new System.Drawing.Size(63, 19);
            this.rdbEstado.TabIndex = 14;
            this.rdbEstado.TabStop = true;
            this.rdbEstado.Text = "Estado";
            this.rdbEstado.UseVisualStyleBackColor = true;
            this.rdbEstado.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // rdbBalance
            // 
            this.rdbBalance.AutoSize = true;
            this.rdbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBalance.Location = new System.Drawing.Point(375, 66);
            this.rdbBalance.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBalance.Name = "rdbBalance";
            this.rdbBalance.Size = new System.Drawing.Size(70, 19);
            this.rdbBalance.TabIndex = 13;
            this.rdbBalance.TabStop = true;
            this.rdbBalance.Text = "Balance";
            this.rdbBalance.UseVisualStyleBackColor = true;
            // 
            // rdbCant
            // 
            this.rdbCant.AutoSize = true;
            this.rdbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCant.Location = new System.Drawing.Point(218, 66);
            this.rdbCant.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCant.Name = "rdbCant";
            this.rdbCant.Size = new System.Drawing.Size(115, 19);
            this.rdbCant.TabIndex = 12;
            this.rdbCant.TabStop = true;
            this.rdbCant.Text = "Cantidad Cuotas";
            this.rdbCant.UseVisualStyleBackColor = true;
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDesc.Location = new System.Drawing.Point(87, 66);
            this.rdbDesc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(90, 19);
            this.rdbDesc.TabIndex = 11;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "Descripción";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.CheckedChanged += new System.EventHandler(this.rdbdesc_CheckedChanged);
            // 
            // rdbEmp
            // 
            this.rdbEmp.AutoSize = true;
            this.rdbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmp.Location = new System.Drawing.Point(496, 34);
            this.rdbEmp.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEmp.Name = "rdbEmp";
            this.rdbEmp.Size = new System.Drawing.Size(95, 19);
            this.rdbEmp.TabIndex = 4;
            this.rdbEmp.TabStop = true;
            this.rdbEmp.Text = "Id Empleado";
            this.rdbEmp.UseVisualStyleBackColor = true;
            this.rdbEmp.CheckedChanged += new System.EventHandler(this.rdbemp_CheckedChanged);
            // 
            // rdbMonto
            // 
            this.rdbMonto.AutoSize = true;
            this.rdbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonto.Location = new System.Drawing.Point(408, 34);
            this.rdbMonto.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMonto.Name = "rdbMonto";
            this.rdbMonto.Size = new System.Drawing.Size(60, 19);
            this.rdbMonto.TabIndex = 3;
            this.rdbMonto.TabStop = true;
            this.rdbMonto.Text = "Monto";
            this.rdbMonto.UseVisualStyleBackColor = true;
            this.rdbMonto.CheckedChanged += new System.EventHandler(this.rdbmonto_CheckedChanged);
            // 
            // rdbCedula
            // 
            this.rdbCedula.AutoSize = true;
            this.rdbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCedula.Location = new System.Drawing.Point(294, 34);
            this.rdbCedula.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCedula.Name = "rdbCedula";
            this.rdbCedula.Size = new System.Drawing.Size(77, 19);
            this.rdbCedula.TabIndex = 2;
            this.rdbCedula.TabStop = true;
            this.rdbCedula.Text = "Id Cédula";
            this.rdbCedula.UseVisualStyleBackColor = true;
            // 
            // rdbDiag
            // 
            this.rdbDiag.AutoSize = true;
            this.rdbDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiag.Location = new System.Drawing.Point(172, 34);
            this.rdbDiag.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDiag.Name = "rdbDiag";
            this.rdbDiag.Size = new System.Drawing.Size(103, 19);
            this.rdbDiag.TabIndex = 1;
            this.rdbDiag.TabStop = true;
            this.rdbDiag.Text = "Id Diagnóstico";
            this.rdbDiag.UseVisualStyleBackColor = true;
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId.Location = new System.Drawing.Point(32, 34);
            this.rdbId.Margin = new System.Windows.Forms.Padding(2);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(95, 19);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Cotización";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Interval = 50;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(226, 107);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(276, 28);
            this.lblEnca.TabIndex = 39;
            this.lblEnca.Text = "Consulta de Cotizaciones";
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
            this.gpbFecha.TabIndex = 38;
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
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.Lavender;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 37;
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
            // FrmConCoti09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(741, 531);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbCriterio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConCoti09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConCoti09";
            this.Activated += new System.EventHandler(this.FrmConCoti09_Activated);
            this.Load += new System.EventHandler(this.FrmConCoti09_Load);
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbCriterio.ResumeLayout(false);
            this.gpbCriterio.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbCriterio;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbEmp;
        private System.Windows.Forms.RadioButton rdbMonto;
        private System.Windows.Forms.RadioButton rdbCedula;
        private System.Windows.Forms.RadioButton rdbDiag;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbEstado;
        private System.Windows.Forms.RadioButton rdbBalance;
        private System.Windows.Forms.RadioButton rdbCant;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnRtn;
    }
}