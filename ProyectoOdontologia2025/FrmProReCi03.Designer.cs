namespace ProyectoOdontologia2025
{
    partial class FrmProReCi03
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
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMot = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtCita = new System.Windows.Forms.TextBox();
            this.lblFechaC = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.lblCita = new System.Windows.Forms.Label();
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHoraC = new System.Windows.Forms.Label();
            this.lblCmt = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblUsu = new System.Windows.Forms.Label();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.gpbInfo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.cbEstado);
            this.gpbInfo.Controls.Add(this.mtbHora);
            this.gpbInfo.Controls.Add(this.mtbFecha);
            this.gpbInfo.Controls.Add(this.mtbCed);
            this.gpbInfo.Controls.Add(this.txtMotivo);
            this.gpbInfo.Controls.Add(this.lblMot);
            this.gpbInfo.Controls.Add(this.txtUsu);
            this.gpbInfo.Controls.Add(this.txtCmt);
            this.gpbInfo.Controls.Add(this.txtDoc);
            this.gpbInfo.Controls.Add(this.lblDoc);
            this.gpbInfo.Controls.Add(this.lblHoraC);
            this.gpbInfo.Controls.Add(this.txtCita);
            this.gpbInfo.Controls.Add(this.lblUsu);
            this.gpbInfo.Controls.Add(this.lblFechaC);
            this.gpbInfo.Controls.Add(this.lblCmt);
            this.gpbInfo.Controls.Add(this.lblCed);
            this.gpbInfo.Controls.Add(this.lblCita);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.ForeColor = System.Drawing.Color.Indigo;
            this.gpbInfo.Location = new System.Drawing.Point(23, 186);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Size = new System.Drawing.Size(514, 240);
            this.gpbInfo.TabIndex = 43;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFecha.Location = new System.Drawing.Point(98, 196);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(107, 21);
            this.mtbFecha.TabIndex = 13;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            this.mtbFecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbFecha_MaskInputRejected);
            // 
            // mtbCed
            // 
            this.mtbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCed.Location = new System.Drawing.Point(98, 71);
            this.mtbCed.Mask = "000-0000000-0";
            this.mtbCed.Name = "mtbCed";
            this.mtbCed.Size = new System.Drawing.Size(107, 21);
            this.mtbCed.TabIndex = 13;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMotivo.Location = new System.Drawing.Point(337, 87);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(107, 21);
            this.txtMotivo.TabIndex = 10;
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMot.Location = new System.Drawing.Point(274, 90);
            this.lblMot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(46, 15);
            this.lblMot.TabIndex = 9;
            this.lblMot.Text = "Motivo:";
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDoc.Location = new System.Drawing.Point(98, 115);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(107, 21);
            this.txtDoc.TabIndex = 10;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoc.Location = new System.Drawing.Point(21, 118);
            this.lblDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(59, 15);
            this.lblDoc.TabIndex = 9;
            this.lblDoc.Text = "Id Doctor:";
            // 
            // txtCita
            // 
            this.txtCita.Enabled = false;
            this.txtCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCita.Location = new System.Drawing.Point(98, 29);
            this.txtCita.Margin = new System.Windows.Forms.Padding(2);
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(107, 21);
            this.txtCita.TabIndex = 6;
            // 
            // lblFechaC
            // 
            this.lblFechaC.AutoSize = true;
            this.lblFechaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaC.Location = new System.Drawing.Point(37, 200);
            this.lblFechaC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaC.Name = "lblFechaC";
            this.lblFechaC.Size = new System.Drawing.Size(44, 15);
            this.lblFechaC.TabIndex = 6;
            this.lblFechaC.Text = "Fecha:";
            this.lblFechaC.Click += new System.EventHandler(this.lblFechaC_Click);
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCed.Location = new System.Drawing.Point(19, 73);
            this.lblCed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(62, 15);
            this.lblCed.TabIndex = 5;
            this.lblCed.Text = "Id Cédula:";
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCita.Location = new System.Drawing.Point(37, 32);
            this.lblCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(44, 15);
            this.lblCita.TabIndex = 4;
            this.lblCita.Text = "Id Cita:";
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(281, 101);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(175, 26);
            this.lblEnca.TabIndex = 51;
            this.lblEnca.Text = "Registro de Citas";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(-9, 154);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(806, 13);
            this.pnlDivision.TabIndex = 44;
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
            this.gpbFecha.TabIndex = 50;
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
            this.lblhora.Location = new System.Drawing.Point(26, 47);
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
            this.gpbTitulo.TabIndex = 48;
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
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(0, 0);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 54;
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Location = new System.Drawing.Point(0, 0);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Size = new System.Drawing.Size(200, 100);
            this.gpbRegistro.TabIndex = 52;
            this.gpbRegistro.TabStop = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(240, 150);
            this.dgvDatos.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Controls.Add(this.dgvCitas);
            this.gpbRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbRegistros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistros.Location = new System.Drawing.Point(23, 445);
            this.gpbRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Size = new System.Drawing.Size(689, 201);
            this.gpbRegistros.TabIndex = 55;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Consultas registradas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(30, 33);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(659, 164);
            this.dgvCitas.TabIndex = 9;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            // 
            // btnLim
            // 
            this.btnLim.BackColor = System.Drawing.Color.Lavender;
            this.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.ForeColor = System.Drawing.Color.Indigo;
            this.btnLim.Location = new System.Drawing.Point(553, 224);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(146, 31);
            this.btnLim.TabIndex = 59;
            this.btnLim.Text = "&Limpiar";
            this.btnLim.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lavender;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(553, 322);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 29);
            this.btnBorrar.TabIndex = 58;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(553, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 56;
            this.button1.Text = "&Retornar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGuard
            // 
            this.btnGuard.BackColor = System.Drawing.Color.Lavender;
            this.btnGuard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuard.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuard.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuard.Location = new System.Drawing.Point(553, 273);
            this.btnGuard.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(146, 28);
            this.btnGuard.TabIndex = 57;
            this.btnGuard.Text = "&Guardar";
            this.btnGuard.UseVisualStyleBackColor = false;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(53, 345);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblHoraC
            // 
            this.lblHoraC.AutoSize = true;
            this.lblHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoraC.Location = new System.Drawing.Point(278, 45);
            this.lblHoraC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraC.Name = "lblHoraC";
            this.lblHoraC.Size = new System.Drawing.Size(37, 15);
            this.lblHoraC.TabIndex = 5;
            this.lblHoraC.Text = "Hora:";
            // 
            // lblCmt
            // 
            this.lblCmt.AutoSize = true;
            this.lblCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCmt.Location = new System.Drawing.Point(246, 132);
            this.lblCmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCmt.Name = "lblCmt";
            this.lblCmt.Size = new System.Drawing.Size(74, 15);
            this.lblCmt.TabIndex = 6;
            this.lblCmt.Text = "Comentario:";
            // 
            // mtbHora
            // 
            this.mtbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbHora.Location = new System.Drawing.Point(337, 42);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(107, 21);
            this.mtbHora.TabIndex = 13;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsu.Location = new System.Drawing.Point(254, 179);
            this.lblUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(66, 15);
            this.lblUsu.TabIndex = 6;
            this.lblUsu.Text = "Id Usuario:";
            // 
            // txtCmt
            // 
            this.txtCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCmt.Location = new System.Drawing.Point(337, 129);
            this.txtCmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(107, 21);
            this.txtCmt.TabIndex = 6;
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsu.Location = new System.Drawing.Point(337, 176);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(107, 21);
            this.txtUsu.TabIndex = 6;
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(98, 155);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(107, 24);
            this.cbEstado.TabIndex = 14;
            // 
            // FrmProReCi03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 672);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuard);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProReCi03";
            this.Text = "Formulario de Procesos: Registro de Cita";
            this.Activated += new System.EventHandler(this.FrmProReCi03_Activated);
            this.Load += new System.EventHandler(this.FrmProReCi03_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtCita;
        private System.Windows.Forms.Label lblFechaC;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label lblCita;
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
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.MaskedTextBox mtbCed;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuard;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblCmt;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHoraC;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}