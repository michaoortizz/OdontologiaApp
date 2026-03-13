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
            this.btnLim = new System.Windows.Forms.Button();
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
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
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
            this.gpbInfo.Controls.Add(this.txtSeguro);
            this.gpbInfo.Controls.Add(this.label17);
            this.gpbInfo.Controls.Add(this.lblSeguro);
            this.gpbInfo.Controls.Add(this.txtCorreo);
            this.gpbInfo.Controls.Add(this.lblCorreo);
            this.gpbInfo.Controls.Add(this.txtCondi);
            this.gpbInfo.Controls.Add(this.lblCondi);
            this.gpbInfo.Controls.Add(this.mtbTel);
            this.gpbInfo.Controls.Add(this.lblTel);
            this.gpbInfo.Controls.Add(this.lblFechaNac);
            this.gpbInfo.Controls.Add(this.txtApellido);
            this.gpbInfo.Controls.Add(this.txtNombre);
            this.gpbInfo.Controls.Add(this.lblApellido);
            this.gpbInfo.Controls.Add(this.lblNombre);
            this.gpbInfo.Controls.Add(this.lblCed);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.ForeColor = System.Drawing.Color.Indigo;
            this.gpbInfo.Location = new System.Drawing.Point(31, 218);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Size = new System.Drawing.Size(695, 289);
            this.gpbInfo.TabIndex = 13;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // btnLim
            // 
            this.btnLim.BackColor = System.Drawing.Color.Lavender;
            this.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.ForeColor = System.Drawing.Color.Indigo;
            this.btnLim.Location = new System.Drawing.Point(755, 352);
            this.btnLim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(195, 34);
            this.btnLim.TabIndex = 37;
            this.btnLim.Text = "&Limpiar";
            this.btnLim.UseVisualStyleBackColor = false;
            this.btnLim.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(531, 38);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(141, 26);
            this.dtpFechaNac.TabIndex = 36;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbGenero.Location = new System.Drawing.Point(153, 197);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(144, 28);
            this.cbGenero.TabIndex = 35;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(48, 202);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 18);
            this.lblGenero.TabIndex = 34;
            this.lblGenero.Text = "Género:";
            // 
            // mtbCed
            // 
            this.mtbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCed.Location = new System.Drawing.Point(153, 38);
            this.mtbCed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCed.Mask = "000-0000000-0";
            this.mtbCed.Name = "mtbCed";
            this.mtbCed.Size = new System.Drawing.Size(144, 24);
            this.mtbCed.TabIndex = 33;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lavender;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(755, 409);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(195, 36);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuardar.Location = new System.Drawing.Point(755, 293);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(195, 34);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(531, 251);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(141, 24);
            this.txtSeguro.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(500, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 26;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.Color.Black;
            this.lblSeguro.Location = new System.Drawing.Point(416, 251);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(75, 18);
            this.lblSeguro.TabIndex = 25;
            this.lblSeguro.Text = "Id Seguro:";
            this.lblSeguro.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(531, 139);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(141, 24);
            this.txtCorreo.TabIndex = 24;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(440, 139);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 18);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCondi
            // 
            this.txtCondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondi.Location = new System.Drawing.Point(531, 194);
            this.txtCondi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCondi.Name = "txtCondi";
            this.txtCondi.Size = new System.Drawing.Size(141, 24);
            this.txtCondi.TabIndex = 22;
            // 
            // lblCondi
            // 
            this.lblCondi.AutoSize = true;
            this.lblCondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondi.ForeColor = System.Drawing.Color.Black;
            this.lblCondi.Location = new System.Drawing.Point(367, 199);
            this.lblCondi.Name = "lblCondi";
            this.lblCondi.Size = new System.Drawing.Size(120, 18);
            this.lblCondi.TabIndex = 21;
            this.lblCondi.Text = "Condición Salud:";
            // 
            // mtbTel
            // 
            this.mtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTel.Location = new System.Drawing.Point(531, 89);
            this.mtbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTel.Mask = "(999)000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(141, 24);
            this.mtbTel.TabIndex = 20;
            this.mtbTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTel_MaskInputRejected);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(423, 92);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(70, 18);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Teléfono:";
            this.lblTel.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNac.Location = new System.Drawing.Point(367, 42);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(132, 18);
            this.lblFechaNac.TabIndex = 9;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            this.lblFechaNac.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(153, 139);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(144, 24);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(153, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 24);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(48, 142);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 18);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(51, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.Color.Black;
            this.lblCed.Location = new System.Drawing.Point(55, 42);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(58, 18);
            this.lblCed.TabIndex = 4;
            this.lblCed.Text = "Cédula:";
            this.lblCed.Click += new System.EventHandler(this.lblCed_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 23);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(895, 172);
            this.dgvDatos.TabIndex = 24;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDatos.Click += new System.EventHandler(this.dgvpacientes_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.Controls.Add(this.dgvDatos);
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(31, 530);
            this.gpbRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbRegistro.Size = new System.Drawing.Size(919, 207);
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
            this.lblEnca.Location = new System.Drawing.Point(295, 127);
            this.lblEnca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(362, 31);
            this.lblEnca.TabIndex = 31;
            this.lblEnca.Text = "Mantenimiento de Pacientes";
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(31, 15);
            this.gpbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbTitulo.Size = new System.Drawing.Size(263, 96);
            this.gpbTitulo.TabIndex = 32;
            this.gpbTitulo.TabStop = false;
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
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
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(9, 26);
            this.lblnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(230, 24);
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
            this.gpbFecha.Location = new System.Drawing.Point(675, 15);
            this.gpbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbFecha.Size = new System.Drawing.Size(275, 96);
            this.gpbFecha.TabIndex = 33;
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
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(27, 55);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(53, 23);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(27, 20);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(61, 23);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha:";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(-11, 182);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(1043, 16);
            this.pnlDivision.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Indigo;
            this.btnSalir.Location = new System.Drawing.Point(955, 15);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 34);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "&X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmManPaci02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(988, 740);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManPaci02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Mantenimiento de Pacientes";
            this.Activated += new System.EventHandler(this.FrmManPaci02_Activated);
            this.Load += new System.EventHandler(this.FrmManPaci02_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
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
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCondi;
        private System.Windows.Forms.Label lblCondi;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DataGridView dgvDatos;
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
        private System.Windows.Forms.Button btnLim;
    }
}