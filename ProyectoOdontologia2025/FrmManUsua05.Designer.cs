namespace ProyectoOdontologia2025
{
    partial class FrmManUsua05
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblNomUsu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.gpbRegistros = new System.Windows.Forms.GroupBox();
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
            this.pnlDivision = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbInfo.SuspendLayout();
            this.gpbRegistros.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(11, 22);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(665, 111);
            this.dgvDatos.TabIndex = 28;
            this.dgvDatos.Click += new System.EventHandler(this.dgvusuarios_Click);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.cbRol);
            this.gpbInfo.Controls.Add(this.lblRol);
            this.gpbInfo.Controls.Add(this.btnBorrar);
            this.gpbInfo.Controls.Add(this.btnGuardar);
            this.gpbInfo.Controls.Add(this.txtEstado);
            this.gpbInfo.Controls.Add(this.lblEstado);
            this.gpbInfo.Controls.Add(this.txtContra);
            this.gpbInfo.Controls.Add(this.lblContra);
            this.gpbInfo.Controls.Add(this.txtNomUsu);
            this.gpbInfo.Controls.Add(this.txtNombre);
            this.gpbInfo.Controls.Add(this.txtUsu);
            this.gpbInfo.Controls.Add(this.lblNomUsu);
            this.gpbInfo.Controls.Add(this.lblNombre);
            this.gpbInfo.Controls.Add(this.lblUsu);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.Location = new System.Drawing.Point(23, 188);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfo.Size = new System.Drawing.Size(689, 172);
            this.gpbInfo.TabIndex = 23;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Información";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(92, 135);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(156, 24);
            this.cbRol.TabIndex = 28;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(57, 138);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(30, 17);
            this.lblRol.TabIndex = 27;
            this.lblRol.Text = "Rol:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Honeydew;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Indigo;
            this.btnBorrar.Location = new System.Drawing.Point(530, 128);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 29);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Indigo;
            this.btnGuardar.Location = new System.Drawing.Point(530, 89);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 28);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(380, 80);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(107, 23);
            this.txtEstado.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(302, 84);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 17);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(380, 29);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(107, 23);
            this.txtContra.TabIndex = 10;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(293, 33);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(77, 17);
            this.lblContra.TabIndex = 9;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsu.Location = new System.Drawing.Point(380, 134);
            this.txtNomUsu.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(107, 23);
            this.txtNomUsu.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(141, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(107, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtUsu
            // 
            this.txtUsu.Enabled = false;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(141, 29);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(107, 23);
            this.txtUsu.TabIndex = 6;
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.AutoSize = true;
            this.lblNomUsu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsu.Location = new System.Drawing.Point(266, 138);
            this.lblNomUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(107, 17);
            this.lblNomUsu.TabIndex = 6;
            this.lblNomUsu.Text = "Nombre usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 84);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre persona:";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(57, 33);
            this.lblUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(72, 17);
            this.lblUsu.TabIndex = 4;
            this.lblUsu.Text = "Id Usuario:";
            // 
            // gpbRegistros
            // 
            this.gpbRegistros.Controls.Add(this.dgvDatos);
            this.gpbRegistros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistros.Location = new System.Drawing.Point(23, 379);
            this.gpbRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Name = "gpbRegistros";
            this.gpbRegistros.Padding = new System.Windows.Forms.Padding(2);
            this.gpbRegistros.Size = new System.Drawing.Size(689, 147);
            this.gpbRegistros.TabIndex = 34;
            this.gpbRegistros.TabStop = false;
            this.gpbRegistros.Text = "Usuarios Registrados";
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Interval = 50;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 35;
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
            this.gpbFecha.TabIndex = 36;
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
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(224, 106);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(278, 26);
            this.lblEnca.TabIndex = 37;
            this.lblEnca.Text = "Mantenimiento de Usuarios";
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
            // FrmManUsua05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 537);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbRegistros);
            this.Controls.Add(this.gpbInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmManUsua05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Mantenimiento de Usuarios";
            this.Activated += new System.EventHandler(this.FrmManUsua05_Activated);
            this.Load += new System.EventHandler(this.FrmManUsua05_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lblNomUsu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gpbRegistros;
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
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblRol;
    }
}