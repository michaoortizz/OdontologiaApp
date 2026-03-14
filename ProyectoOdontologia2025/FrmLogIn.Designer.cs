namespace ProyectoOdontologia2025
{
    partial class FrmLogIn
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCtr = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.gpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Indigo;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnIniciar.Location = new System.Drawing.Point(108, 153);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(199, 38);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(199, 63);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 25);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Indigo;
            this.lblUsuario.Location = new System.Drawing.Point(87, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCtr
            // 
            this.lblCtr.AutoSize = true;
            this.lblCtr.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtr.ForeColor = System.Drawing.Color.Indigo;
            this.lblCtr.Location = new System.Drawing.Point(63, 104);
            this.lblCtr.Name = "lblCtr";
            this.lblCtr.Size = new System.Drawing.Size(88, 19);
            this.lblCtr.TabIndex = 4;
            this.lblCtr.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitulo.Location = new System.Drawing.Point(147, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 27);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Inicio de Sesión";
            // 
            // gpbInfo
            // 
            this.gpbInfo.BackColor = System.Drawing.Color.Lavender;
            this.gpbInfo.Controls.Add(this.btnIniciar);
            this.gpbInfo.Controls.Add(this.btnOpen);
            this.gpbInfo.Controls.Add(this.btnSlash);
            this.gpbInfo.Controls.Add(this.txtCon);
            this.gpbInfo.Controls.Add(this.txtUsuario);
            this.gpbInfo.Controls.Add(this.lblCtr);
            this.gpbInfo.Controls.Add(this.lblUsuario);
            this.gpbInfo.Location = new System.Drawing.Point(44, 117);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(410, 206);
            this.gpbInfo.TabIndex = 6;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Enter += new System.EventHandler(this.gpbInfo_Enter);
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(199, 104);
            this.txtCon.Multiline = true;
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(134, 25);
            this.txtCon.TabIndex = 1;
            this.txtCon.TextChanged += new System.EventHandler(this.txtCon_TextChanged);
            this.txtCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoOdontologia2025.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(191, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 107);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Window;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnOpen.Image = global::ProyectoOdontologia2025.Properties.Resources.see;
            this.btnOpen.Location = new System.Drawing.Point(308, 104);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(25, 25);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnSlash
            // 
            this.btnSlash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSlash.FlatAppearance.BorderSize = 0;
            this.btnSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlash.Image = global::ProyectoOdontologia2025.Properties.Resources.nosee;
            this.btnSlash.Location = new System.Drawing.Point(308, 104);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(25, 25);
            this.btnSlash.TabIndex = 6;
            this.btnSlash.UseVisualStyleBackColor = true;
            this.btnSlash.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(483, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión: Clinica Dental Dr. Cepin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCtr;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSlash;
    }
}