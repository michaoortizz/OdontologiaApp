namespace ProyectoOdontologia2025
{
    partial class FrmProCoti05
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
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.mtbCed = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaCoti = new System.Windows.Forms.Label();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.lblDet = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCed = new System.Windows.Forms.Label();
            this.lblCoti = new System.Windows.Forms.Label();
            this.lblEnca = new System.Windows.Forms.Label();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnLim = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gpbInfo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.mtbFecha);
            this.gpbInfo.Controls.Add(this.mtbCed);
            this.gpbInfo.Controls.Add(this.lblFechaCoti);
            this.gpbInfo.Controls.Add(this.txtDet);
            this.gpbInfo.Controls.Add(this.lblDet);
            this.gpbInfo.Controls.Add(this.txtEmp);
            this.gpbInfo.Controls.Add(this.lblEmp);
            this.gpbInfo.Controls.Add(this.txtMonto);
            this.gpbInfo.Controls.Add(this.lblMonto);
            this.gpbInfo.Controls.Add(this.txtId);
            this.gpbInfo.Controls.Add(this.lblCed);
            this.gpbInfo.Controls.Add(this.lblCoti);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.ForeColor = System.Drawing.Color.Indigo;
            this.gpbInfo.Location = new System.Drawing.Point(21, 210);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Size = new System.Drawing.Size(696, 209);
            this.gpbInfo.TabIndex = 25;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(180, 142);
            this.mtbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(141, 26);
            this.mtbFecha.TabIndex = 22;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // mtbCed
            // 
            this.mtbCed.Location = new System.Drawing.Point(180, 96);
            this.mtbCed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCed.Mask = "000-0000000-0";
            this.mtbCed.Name = "mtbCed";
            this.mtbCed.Size = new System.Drawing.Size(141, 26);
            this.mtbCed.TabIndex = 21;
            // 
            // lblFechaCoti
            // 
            this.lblFechaCoti.AutoSize = true;
            this.lblFechaCoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCoti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaCoti.Location = new System.Drawing.Point(88, 144);
            this.lblFechaCoti.Name = "lblFechaCoti";
            this.lblFechaCoti.Size = new System.Drawing.Size(53, 18);
            this.lblFechaCoti.TabIndex = 17;
            this.lblFechaCoti.Text = "Fecha:";
            // 
            // txtDet
            // 
            this.txtDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDet.Location = new System.Drawing.Point(503, 92);
            this.txtDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDet.Name = "txtDet";
            this.txtDet.Size = new System.Drawing.Size(141, 24);
            this.txtDet.TabIndex = 14;
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDet.Location = new System.Drawing.Point(407, 100);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(65, 18);
            this.lblDet.TabIndex = 13;
            this.lblDet.Text = "Detalles:";
            // 
            // txtEmp
            // 
            this.txtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmp.Location = new System.Drawing.Point(503, 139);
            this.txtEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(141, 24);
            this.txtEmp.TabIndex = 12;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmp.Location = new System.Drawing.Point(373, 143);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(94, 18);
            this.lblEmp.TabIndex = 11;
            this.lblEmp.Text = "Id Empleado:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Location = new System.Drawing.Point(503, 53);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(141, 24);
            this.txtMonto.TabIndex = 10;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMonto.Location = new System.Drawing.Point(420, 58);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 18);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Location = new System.Drawing.Point(180, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 24);
            this.txtId.TabIndex = 6;
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCed.Location = new System.Drawing.Point(72, 100);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(73, 18);
            this.lblCed.TabIndex = 6;
            this.lblCed.Text = "Id Cédula:";
            // 
            // lblCoti
            // 
            this.lblCoti.AutoSize = true;
            this.lblCoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCoti.Location = new System.Drawing.Point(45, 59);
            this.lblCoti.Name = "lblCoti";
            this.lblCoti.Size = new System.Drawing.Size(98, 18);
            this.lblCoti.TabIndex = 4;
            this.lblCoti.Text = "Id Cotización:";
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(325, 122);
            this.lblEnca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(306, 31);
            this.lblEnca.TabIndex = 59;
            this.lblEnca.Text = "Proceso de Cotizaciones";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(-21, 180);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(1024, 16);
            this.pnlDivision.TabIndex = 52;
            // 
            // gpbFecha
            // 
            this.gpbFecha.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbFecha.Controls.Add(this.lblhora2);
            this.gpbFecha.Controls.Add(this.lblfecha2);
            this.gpbFecha.Controls.Add(this.lblhora);
            this.gpbFecha.Controls.Add(this.lblfecha);
            this.gpbFecha.Location = new System.Drawing.Point(675, 15);
            this.gpbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFecha.Size = new System.Drawing.Size(275, 96);
            this.gpbFecha.TabIndex = 58;
            this.gpbFecha.TabStop = false;
            // 
            // lblhora2
            // 
            this.lblhora2.BackColor = System.Drawing.Color.White;
            this.lblhora2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora2.Location = new System.Drawing.Point(155, 58);
            this.lblhora2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora2.Name = "lblhora2";
            this.lblhora2.Size = new System.Drawing.Size(103, 23);
            this.lblhora2.TabIndex = 3;
            // 
            // lblfecha2
            // 
            this.lblfecha2.BackColor = System.Drawing.Color.White;
            this.lblfecha2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha2.Location = new System.Drawing.Point(155, 20);
            this.lblfecha2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(103, 23);
            this.lblfecha2.TabIndex = 2;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.MediumPurple;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(35, 58);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(53, 23);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.MediumPurple;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(27, 20);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(61, 23);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha:";
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 15);
            this.gpbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbTitulo.Size = new System.Drawing.Size(263, 96);
            this.gpbTitulo.TabIndex = 56;
            this.gpbTitulo.TabStop = false;
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.BackColor = System.Drawing.Color.MediumPurple;
            this.lblnom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.ForeColor = System.Drawing.Color.White;
            this.lblnom1.Location = new System.Drawing.Point(17, 55);
            this.lblnom1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(218, 23);
            this.lblnom1.TabIndex = 1;
            this.lblnom1.Text = "Politécnico Las Mercedes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.MediumPurple;
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(9, 26);
            this.lblnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(230, 24);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Consultorio Odontológico";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lavender;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(745, 325);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(195, 36);
            this.btnBorrar.TabIndex = 55;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.Lavender;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.ForeColor = System.Drawing.Color.Indigo;
            this.btnRetornar.Location = new System.Drawing.Point(745, 377);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(195, 37);
            this.btnRetornar.TabIndex = 53;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuardar.Location = new System.Drawing.Point(745, 276);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(195, 34);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.dgvDatos);
            this.gpbRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(112, 439);
            this.gpbRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbRegistro.Size = new System.Drawing.Size(696, 268);
            this.gpbRegistro.TabIndex = 57;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Consultas registradas";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(33, 37);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(624, 208);
            this.dgvDatos.TabIndex = 9;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // btnLim
            // 
            this.btnLim.BackColor = System.Drawing.Color.Lavender;
            this.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.ForeColor = System.Drawing.Color.Indigo;
            this.btnLim.Location = new System.Drawing.Point(745, 226);
            this.btnLim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(195, 34);
            this.btnLim.TabIndex = 54;
            this.btnLim.Text = "&Limpiar";
            this.btnLim.UseVisualStyleBackColor = false;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmProCoti05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(981, 750);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbRegistro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProCoti05";
            this.Text = "Formulario de Proceso de Cotización";
            this.Activated += new System.EventHandler(this.FrmProCoti05_Activated);
            this.Load += new System.EventHandler(this.FrmProCoti05_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label lblCoti;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFechaCoti;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MaskedTextBox mtbCed;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.Timer timer;
    }
}