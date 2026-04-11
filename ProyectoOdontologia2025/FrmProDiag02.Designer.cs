namespace ProyectoOdontologia2025
{
    partial class FrmProDiag02
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
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnLim = new System.Windows.Forms.Button();
            this.mtbCed = new System.Windows.Forms.MaskedTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblFec = new System.Windows.Forms.Label();
            this.lblDiag = new System.Windows.Forms.Label();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gpbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbInfo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.dgvDatos);
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(24, 386);
            this.gpbRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRegistro.Size = new System.Drawing.Size(688, 168);
            this.gpbRegistro.TabIndex = 39;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Diagnósticos Registrados";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(54, 19);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(597, 134);
            this.dgvDatos.TabIndex = 9;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.mtbFecha);
            this.gpbInfo.Controls.Add(this.btnLim);
            this.gpbInfo.Controls.Add(this.mtbCed);
            this.gpbInfo.Controls.Add(this.btnBorrar);
            this.gpbInfo.Controls.Add(this.btnRetornar);
            this.gpbInfo.Controls.Add(this.btnGuardar);
            this.gpbInfo.Controls.Add(this.txtCon);
            this.gpbInfo.Controls.Add(this.lblCon);
            this.gpbInfo.Controls.Add(this.txtDesc);
            this.gpbInfo.Controls.Add(this.lblDesc);
            this.gpbInfo.Controls.Add(this.lblCed);
            this.gpbInfo.Controls.Add(this.txtDoc);
            this.gpbInfo.Controls.Add(this.txtDiag);
            this.gpbInfo.Controls.Add(this.lblDoc);
            this.gpbInfo.Controls.Add(this.lblFec);
            this.gpbInfo.Controls.Add(this.lblDiag);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.ForeColor = System.Drawing.Color.Indigo;
            this.gpbInfo.Location = new System.Drawing.Point(23, 188);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Size = new System.Drawing.Size(689, 181);
            this.gpbInfo.TabIndex = 34;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(361, 41);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(107, 22);
            this.mtbFecha.TabIndex = 32;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnLim
            // 
            this.btnLim.BackColor = System.Drawing.Color.Lavender;
            this.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.Location = new System.Drawing.Point(506, 16);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(146, 28);
            this.btnLim.TabIndex = 31;
            this.btnLim.Text = "&Limpiar";
            this.btnLim.UseVisualStyleBackColor = false;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // mtbCed
            // 
            this.mtbCed.Location = new System.Drawing.Point(137, 81);
            this.mtbCed.Mask = "000-0000000-0";
            this.mtbCed.Name = "mtbCed";
            this.mtbCed.Size = new System.Drawing.Size(107, 22);
            this.mtbCed.TabIndex = 30;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lavender;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(507, 96);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 29);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.Lavender;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetornar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.ForeColor = System.Drawing.Color.Indigo;
            this.btnRetornar.Location = new System.Drawing.Point(507, 136);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(146, 30);
            this.btnRetornar.TabIndex = 27;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuardar.Location = new System.Drawing.Point(507, 56);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 28);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCon.Location = new System.Drawing.Point(361, 125);
            this.txtCon.Margin = new System.Windows.Forms.Padding(2);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(107, 23);
            this.txtCon.TabIndex = 12;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCon.Location = new System.Drawing.Point(269, 128);
            this.lblCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCon.Size = new System.Drawing.Size(77, 17);
            this.lblCon.TabIndex = 11;
            this.lblCon.Text = "Id Consulta:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Location = new System.Drawing.Point(361, 81);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(107, 23);
            this.txtDesc.TabIndex = 12;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDesc.Location = new System.Drawing.Point(269, 84);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCed.Location = new System.Drawing.Point(54, 84);
            this.lblCed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(67, 17);
            this.lblCed.TabIndex = 9;
            this.lblCed.Text = "Id Cédula:";
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDoc.Location = new System.Drawing.Point(137, 127);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(107, 23);
            this.txtDoc.TabIndex = 8;
            // 
            // txtDiag
            // 
            this.txtDiag.Enabled = false;
            this.txtDiag.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiag.Location = new System.Drawing.Point(137, 41);
            this.txtDiag.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(107, 23);
            this.txtDiag.TabIndex = 6;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoc.Location = new System.Drawing.Point(54, 130);
            this.lblDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(67, 17);
            this.lblDoc.TabIndex = 6;
            this.lblDoc.Text = "Id Doctor:";
            // 
            // lblFec
            // 
            this.lblFec.AutoSize = true;
            this.lblFec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFec.Location = new System.Drawing.Point(300, 43);
            this.lblFec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFec.Name = "lblFec";
            this.lblFec.Size = new System.Drawing.Size(44, 17);
            this.lblFec.TabIndex = 5;
            this.lblFec.Text = "Fecha:";
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiag.Location = new System.Drawing.Point(25, 44);
            this.lblDiag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(96, 17);
            this.lblDiag.TabIndex = 4;
            this.lblDiag.Text = "Id Diagnóstico:";
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(244, 106);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(236, 26);
            this.lblEnca.TabIndex = 43;
            this.lblEnca.Text = "Proceso de Diagnóstico";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(-9, 154);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(768, 13);
            this.pnlDivision.TabIndex = 40;
            // 
            // gpbFecha
            // 
            this.gpbFecha.BackColor = System.Drawing.Color.MediumPurple;
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
            this.lblhora.BackColor = System.Drawing.Color.MediumPurple;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(20, 45);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(42, 19);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.MediumPurple;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(20, 16);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 19);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha:";
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
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
            this.lblnom1.BackColor = System.Drawing.Color.MediumPurple;
            this.lblnom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.ForeColor = System.Drawing.Color.White;
            this.lblnom1.Location = new System.Drawing.Point(13, 45);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(164, 19);
            this.lblnom1.TabIndex = 1;
            this.lblnom1.Text = "Politécnico Las Mercedes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.MediumPurple;
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(7, 21);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(183, 19);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Consultorio Odontológico";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmProDiag02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 565);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProDiag02";
            this.Text = "Formulario de Proceso de Diagnóstico";
            this.Activated += new System.EventHandler(this.FrmProDiag02_Activated);
            this.Load += new System.EventHandler(this.FrmProDiag02_Load);
            this.gpbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblFec;
        private System.Windows.Forms.Label lblDiag;
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
        private System.Windows.Forms.MaskedTextBox mtbCed;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.Timer timer;
    }
}