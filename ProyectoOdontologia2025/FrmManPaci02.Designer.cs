namespace ProyectoOdontologia2025
{
    partial class FrmManPaci02
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.mtbCed = new System.Windows.Forms.MaskedTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCondi = new System.Windows.Forms.TextBox();
            this.lblCondi = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.dgvpacientes = new System.Windows.Forms.DataGridView();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.lblEnca = new System.Windows.Forms.Label();
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            this.gpbRegistro.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.dtpFechaNac);
            this.gpbInfo.Controls.Add(this.cbGenero);
            this.gpbInfo.Controls.Add(this.lblGenero);
            this.gpbInfo.Controls.Add(this.mtbCed);
            this.gpbInfo.Controls.Add(this.btnBorrar);
            this.gpbInfo.Controls.Add(this.btnGuardar);
            this.gpbInfo.Controls.Add(this.txtSeguro);
            this.gpbInfo.Controls.Add(this.label17);
            this.gpbInfo.Controls.Add(this.lblSeguro);
            this.gpbInfo.Controls.Add(this.txtCorreo);
            this.gpbInfo.Controls.Add(this.lblCorreo);
            this.gpbInfo.Controls.Add(this.txtCondi);
            this.gpbInfo.Controls.Add(this.lblCondi);
            this.gpbInfo.Controls.Add(this.mtbTel);
            this.gpbInfo.Controls.Add(this.lblTel);
            this.gpbInfo.Controls.Add(this.txtTipo);
            this.gpbInfo.Controls.Add(this.lblTipo);
            this.gpbInfo.Controls.Add(this.lblFechaNac);
            this.gpbInfo.Controls.Add(this.txtApellido);
            this.gpbInfo.Controls.Add(this.txtNombre);
            this.gpbInfo.Controls.Add(this.lblApellido);
            this.gpbInfo.Controls.Add(this.lblNombre);
            this.gpbInfo.Controls.Add(this.lblCed);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.Location = new System.Drawing.Point(23, 177);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Size = new System.Drawing.Size(689, 235);
            this.gpbInfo.TabIndex = 13;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(142, 203);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaNac.TabIndex = 36;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbGenero.Location = new System.Drawing.Point(142, 160);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 24);
            this.cbGenero.TabIndex = 35;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(63, 164);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(51, 15);
            this.lblGenero.TabIndex = 34;
            this.lblGenero.Text = "Genero:";
            // 
            // mtbCed
            // 
            this.mtbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCed.Location = new System.Drawing.Point(142, 31);
            this.mtbCed.Mask = "000-0000000-0";
            this.mtbCed.Name = "mtbCed";
            this.mtbCed.Size = new System.Drawing.Size(109, 21);
            this.mtbCed.TabIndex = 33;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Honeydew;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(530, 197);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 29);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuardar.Location = new System.Drawing.Point(530, 155);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 28);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(398, 204);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(107, 21);
            this.txtSeguro.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(375, 99);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 26;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(312, 204);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(63, 15);
            this.lblSeguro.TabIndex = 25;
            this.lblSeguro.Text = "Id Seguro:";
            this.lblSeguro.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(398, 74);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(107, 21);
            this.txtCorreo.TabIndex = 24;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(330, 74);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 15);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCondi
            // 
            this.txtCondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondi.Location = new System.Drawing.Point(398, 158);
            this.txtCondi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondi.Name = "txtCondi";
            this.txtCondi.Size = new System.Drawing.Size(107, 21);
            this.txtCondi.TabIndex = 22;
            // 
            // lblCondi
            // 
            this.lblCondi.AutoSize = true;
            this.lblCondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondi.Location = new System.Drawing.Point(275, 162);
            this.lblCondi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCondi.Name = "lblCondi";
            this.lblCondi.Size = new System.Drawing.Size(100, 15);
            this.lblCondi.TabIndex = 21;
            this.lblCondi.Text = "Condición Salud:";
            // 
            // mtbTel
            // 
            this.mtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTel.Location = new System.Drawing.Point(398, 35);
            this.mtbTel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTel.Mask = "(999)000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(107, 21);
            this.mtbTel.TabIndex = 20;
            this.mtbTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTel_MaskInputRejected);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(317, 36);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 15);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Teléfono:";
            this.lblTel.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(398, 115);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(107, 21);
            this.txtTipo.TabIndex = 12;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(285, 119);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(85, 15);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo Paciente:";
            this.lblTipo.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(7, 203);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(110, 15);
            this.lblFechaNac.TabIndex = 9;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            this.lblFechaNac.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(142, 113);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(109, 21);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 21);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(63, 115);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(65, 74);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.Location = new System.Drawing.Point(54, 35);
            this.lblCed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(49, 15);
            this.lblCed.TabIndex = 4;
            this.lblCed.Text = "Cédula:";
            this.lblCed.Click += new System.EventHandler(this.lblCed_Click);
            // 
            // dgvpacientes
            // 
            this.dgvpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpacientes.Location = new System.Drawing.Point(9, 19);
            this.dgvpacientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.RowHeadersWidth = 51;
            this.dgvpacientes.RowTemplate.Height = 24;
            this.dgvpacientes.Size = new System.Drawing.Size(671, 140);
            this.dgvpacientes.TabIndex = 24;
            this.dgvpacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvpacientes.Click += new System.EventHandler(this.dgvpacientes_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.dgvpacientes);
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(23, 431);
            this.gpbRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRegistro.Size = new System.Drawing.Size(689, 168);
            this.gpbRegistro.TabIndex = 28;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Pacientes Registrados";
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
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(221, 103);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(286, 26);
            this.lblEnca.TabIndex = 31;
            this.lblEnca.Text = "Mantenimiento de Pacientes";
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 32;
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
            this.gpbFecha.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbFecha.Controls.Add(this.lblhora2);
            this.gpbFecha.Controls.Add(this.lblfecha2);
            this.gpbFecha.Controls.Add(this.lblhora);
            this.gpbFecha.Controls.Add(this.lblfecha);
            this.gpbFecha.Location = new System.Drawing.Point(506, 12);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(206, 78);
            this.gpbFecha.TabIndex = 33;
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
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(-8, 148);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(782, 13);
            this.pnlDivision.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Indigo;
            this.btnSalir.Location = new System.Drawing.Point(716, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 28);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "&X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmManPaci02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 601);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmManPaci02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Mantenimiento de Pacientes";
            this.Activated += new System.EventHandler(this.FrmManPaci02_Activated);
            this.Load += new System.EventHandler(this.FrmManPaci02_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            this.gpbRegistro.ResumeLayout(false);
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCondi;
        private System.Windows.Forms.Label lblCondi;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DataGridView dgvpacientes;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox mtbCed;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnSalir;
    }
}