namespace ProyectoOdontologia2025
{
    partial class FrmConCmed02
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
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.gpbTitulo = new System.Windows.Forms.GroupBox();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.rdbMotivo = new System.Windows.Forms.RadioButton();
            this.rdbCed = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbDoc = new System.Windows.Forms.RadioButton();
            this.gpbCriterios = new System.Windows.Forms.GroupBox();
            this.rbdObs = new System.Windows.Forms.RadioButton();
            this.btnRtn = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblconsultas = new System.Windows.Forms.Label();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.lblhora2 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblEnca = new System.Windows.Forms.Label();
            this.gpbTitulo.SuspendLayout();
            this.gpbCriterios.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Interval = 50;
            this.Fecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.Lavender;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(23, 12);
            this.gpbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.gpbTitulo.Size = new System.Drawing.Size(198, 78);
            this.gpbTitulo.TabIndex = 17;
            this.gpbTitulo.TabStop = false;
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.Location = new System.Drawing.Point(13, 44);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(164, 19);
            this.lblnom1.TabIndex = 3;
            this.lblnom1.Text = "Politécnico Las Mercedes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(7, 20);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(183, 19);
            this.lblnom.TabIndex = 2;
            this.lblnom.Text = "Consultorio Odontológico";
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId.Location = new System.Drawing.Point(23, 44);
            this.rdbId.Margin = new System.Windows.Forms.Padding(2);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(92, 21);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Consulta";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // rdbMotivo
            // 
            this.rdbMotivo.AutoSize = true;
            this.rdbMotivo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMotivo.Location = new System.Drawing.Point(449, 44);
            this.rdbMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMotivo.Name = "rdbMotivo";
            this.rdbMotivo.Size = new System.Drawing.Size(67, 21);
            this.rdbMotivo.TabIndex = 1;
            this.rdbMotivo.TabStop = true;
            this.rdbMotivo.Text = "Motivo";
            this.rdbMotivo.UseVisualStyleBackColor = true;
            // 
            // rdbCed
            // 
            this.rdbCed.AutoSize = true;
            this.rdbCed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCed.Location = new System.Drawing.Point(146, 44);
            this.rdbCed.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCed.Name = "rdbCed";
            this.rdbCed.Size = new System.Drawing.Size(82, 21);
            this.rdbCed.TabIndex = 2;
            this.rdbCed.TabStop = true;
            this.rdbCed.Text = "Id Cédula";
            this.rdbCed.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFecha.Location = new System.Drawing.Point(362, 44);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(63, 21);
            this.rdbFecha.TabIndex = 3;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha ";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbDoc
            // 
            this.rdbDoc.AutoSize = true;
            this.rdbDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoc.Location = new System.Drawing.Point(256, 44);
            this.rdbDoc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDoc.Name = "rdbDoc";
            this.rdbDoc.Size = new System.Drawing.Size(82, 21);
            this.rdbDoc.TabIndex = 4;
            this.rdbDoc.TabStop = true;
            this.rdbDoc.Text = "Id Doctor";
            this.rdbDoc.UseVisualStyleBackColor = true;
            this.rdbDoc.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // gpbCriterios
            // 
            this.gpbCriterios.BackColor = System.Drawing.Color.Lavender;
            this.gpbCriterios.Controls.Add(this.rbdObs);
            this.gpbCriterios.Controls.Add(this.btnRtn);
            this.gpbCriterios.Controls.Add(this.txtBusqueda);
            this.gpbCriterios.Controls.Add(this.lblBusqueda);
            this.gpbCriterios.Controls.Add(this.rdbDoc);
            this.gpbCriterios.Controls.Add(this.rdbFecha);
            this.gpbCriterios.Controls.Add(this.rdbCed);
            this.gpbCriterios.Controls.Add(this.rdbMotivo);
            this.gpbCriterios.Controls.Add(this.rdbId);
            this.gpbCriterios.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCriterios.Location = new System.Drawing.Point(23, 166);
            this.gpbCriterios.Margin = new System.Windows.Forms.Padding(2);
            this.gpbCriterios.Name = "gpbCriterios";
            this.gpbCriterios.Padding = new System.Windows.Forms.Padding(2);
            this.gpbCriterios.Size = new System.Drawing.Size(688, 142);
            this.gpbCriterios.TabIndex = 20;
            this.gpbCriterios.TabStop = false;
            this.gpbCriterios.Text = "Criterios de busqueda";
            this.gpbCriterios.Enter += new System.EventHandler(this.gpb3_Enter);
            // 
            // rbdObs
            // 
            this.rbdObs.AutoSize = true;
            this.rbdObs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdObs.Location = new System.Drawing.Point(545, 44);
            this.rbdObs.Margin = new System.Windows.Forms.Padding(2);
            this.rbdObs.Name = "rbdObs";
            this.rbdObs.Size = new System.Drawing.Size(112, 21);
            this.rbdObs.TabIndex = 15;
            this.rbdObs.TabStop = true;
            this.rbdObs.Text = "Observaciones";
            this.rbdObs.UseVisualStyleBackColor = true;
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Location = new System.Drawing.Point(492, 90);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(156, 35);
            this.btnRtn.TabIndex = 14;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            this.btnRtn.Click += new System.EventHandler(this.btnRtn_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(256, 99);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 22);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(20, 99);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(196, 19);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Digite criterio de búsqueda:";
            // 
            // lblconsultas
            // 
            this.lblconsultas.AutoSize = true;
            this.lblconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultas.Location = new System.Drawing.Point(285, 112);
            this.lblconsultas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconsultas.Name = "lblconsultas";
            this.lblconsultas.Size = new System.Drawing.Size(0, 17);
            this.lblconsultas.TabIndex = 19;
            // 
            // gpbFecha
            // 
            this.gpbFecha.BackColor = System.Drawing.Color.Lavender;
            this.gpbFecha.Controls.Add(this.lblhora2);
            this.gpbFecha.Controls.Add(this.lblfecha2);
            this.gpbFecha.Controls.Add(this.lblhora);
            this.gpbFecha.Controls.Add(this.lblfecha);
            this.gpbFecha.Location = new System.Drawing.Point(506, 12);
            this.gpbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gpbFecha.Size = new System.Drawing.Size(206, 78);
            this.gpbFecha.TabIndex = 18;
            this.gpbFecha.TabStop = false;
            // 
            // lblhora2
            // 
            this.lblhora2.BackColor = System.Drawing.Color.White;
            this.lblhora2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora2.Location = new System.Drawing.Point(112, 47);
            this.lblhora2.Name = "lblhora2";
            this.lblhora2.Size = new System.Drawing.Size(77, 19);
            this.lblhora2.TabIndex = 7;
            // 
            // lblfecha2
            // 
            this.lblfecha2.BackColor = System.Drawing.Color.White;
            this.lblfecha2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha2.Location = new System.Drawing.Point(112, 16);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(77, 19);
            this.lblfecha2.TabIndex = 6;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(16, 45);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(42, 19);
            this.lblhora.TabIndex = 5;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(16, 16);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 19);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "Fecha:";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvDatos);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(24, 342);
            this.gpbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Size = new System.Drawing.Size(688, 180);
            this.gpbResultado.TabIndex = 21;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado de búsqueda";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(64, 20);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(573, 151);
            this.dgvDatos.TabIndex = 1;
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(195, 106);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(339, 28);
            this.lblEnca.TabIndex = 30;
            this.lblEnca.Text = "Consulta de Consultas Médicas";
            // 
            // FrmConCmed02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(740, 525);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbCriterios);
            this.Controls.Add(this.lblconsultas);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConCmed02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Consultas Médicas";
            this.Activated += new System.EventHandler(this.FrmConCmed02_Activated);
            this.Load += new System.EventHandler(this.FrmConCmed02_Load);
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbCriterios.ResumeLayout(false);
            this.gpbCriterios.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbMotivo;
        private System.Windows.Forms.RadioButton rdbCed;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbDoc;
        private System.Windows.Forms.GroupBox gpbCriterios;
        private System.Windows.Forms.Label lblconsultas;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnRtn;
        private System.Windows.Forms.RadioButton rbdObs;
    }
}