namespace ProyectoOdontologia2025
{
    partial class FrmManEmpl04
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
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.lblDirec = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
            this.fecha = new System.Windows.Forms.Timer(this.components);
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.lblEnca = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.gpbInfo.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(11, 19);
            this.dgvempleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.RowHeadersWidth = 51;
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.Size = new System.Drawing.Size(669, 135);
            this.dgvempleados.TabIndex = 28;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick);
            this.dgvempleados.Click += new System.EventHandler(this.dgvempleados_Click);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.btnBorrar);
            this.gpbInfo.Controls.Add(this.btnGuardar);
            this.gpbInfo.Controls.Add(this.txtCargo);
            this.gpbInfo.Controls.Add(this.lblCargo);
            this.gpbInfo.Controls.Add(this.mtbTel);
            this.gpbInfo.Controls.Add(this.lblTel);
            this.gpbInfo.Controls.Add(this.txtDirec);
            this.gpbInfo.Controls.Add(this.lblDirec);
            this.gpbInfo.Controls.Add(this.txtApellido);
            this.gpbInfo.Controls.Add(this.txtNombre);
            this.gpbInfo.Controls.Add(this.txtId);
            this.gpbInfo.Controls.Add(this.lblApellido);
            this.gpbInfo.Controls.Add(this.lblNombre);
            this.gpbInfo.Controls.Add(this.lblEmp);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.Location = new System.Drawing.Point(23, 183);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Size = new System.Drawing.Size(689, 168);
            this.gpbInfo.TabIndex = 23;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Honeydew;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(507, 111);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 29);
            this.btnBorrar.TabIndex = 35;
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
            this.btnGuardar.Location = new System.Drawing.Point(507, 72);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 28);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(351, 117);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(107, 23);
            this.txtCargo.TabIndex = 32;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(290, 121);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(47, 17);
            this.lblCargo.TabIndex = 31;
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.Click += new System.EventHandler(this.label13_Click);
            // 
            // mtbTel
            // 
            this.mtbTel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTel.Location = new System.Drawing.Point(351, 72);
            this.mtbTel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTel.Mask = "(999)000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(107, 23);
            this.mtbTel.TabIndex = 30;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(273, 76);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 17);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtDirec
            // 
            this.txtDirec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirec.Location = new System.Drawing.Point(351, 25);
            this.txtDirec.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(107, 23);
            this.txtDirec.TabIndex = 10;
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.Location = new System.Drawing.Point(269, 27);
            this.lblDirec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(65, 17);
            this.lblDirec.TabIndex = 9;
            this.lblDirec.Text = "Dirección:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(113, 117);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(107, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(113, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(107, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(113, 29);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(107, 23);
            this.txtId.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(39, 121);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(46, 76);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(19, 34);
            this.lblEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(86, 17);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Id Empleado:";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Controls.Add(this.dgvempleados);
            this.gpbRegistros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistros.Location = new System.Drawing.Point(23, 364);
            this.gpbRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Size = new System.Drawing.Size(689, 165);
            this.gpbRegistros.TabIndex = 35;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Empleados Registrados";
            // 
            // fecha
            // 
            this.fecha.Enabled = true;
            this.fecha.Interval = 50;
            this.fecha.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 36;
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
            this.gpbFecha.TabIndex = 37;
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
            this.lblhora2.Click += new System.EventHandler(this.lblhora2_Click);
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
            this.pnlDivision.Location = new System.Drawing.Point(-14, 154);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(768, 13);
            this.pnlDivision.TabIndex = 38;
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(216, 104);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(301, 26);
            this.lblEnca.TabIndex = 39;
            this.lblEnca.Text = "Mantenimiento de Empleados";
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
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "&X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmManEmpl04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 540);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmManEmpl04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Mantenimiento de Empleados";
            this.Activated += new System.EventHandler(this.FrmManEmpl04_Activated);
            this.Load += new System.EventHandler(this.FrmManEmpl04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbRegistros.ResumeLayout(false);
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.GroupBox gpbRegistros;
        private System.Windows.Forms.Timer fecha;
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
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.Button btnSalir;
    }
}