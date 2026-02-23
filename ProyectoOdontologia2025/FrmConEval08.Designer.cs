namespace ProyectoOdontologia2025
{
    partial class FrmConEval08
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
            this.label9 = new System.Windows.Forms.Label();
            this.rdbCed = new System.Windows.Forms.RadioButton();
            this.rdbResu = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbDoc = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
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
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbCriterio.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvDatos);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(23, 347);
            this.gpbResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbResultado.Size = new System.Drawing.Size(689, 173);
            this.gpbResultado.TabIndex = 31;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado de búsqueda";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(26, 24);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(637, 134);
            this.dgvDatos.TabIndex = 0;
            // 
            // gpbCriterio
            // 
            this.gpbCriterio.BackColor = System.Drawing.Color.Lavender;
            this.gpbCriterio.Controls.Add(this.btnRtn);
            this.gpbCriterio.Controls.Add(this.txtBusqueda);
            this.gpbCriterio.Controls.Add(this.lblBusqueda);
            this.gpbCriterio.Controls.Add(this.label9);
            this.gpbCriterio.Controls.Add(this.rdbCed);
            this.gpbCriterio.Controls.Add(this.rdbResu);
            this.gpbCriterio.Controls.Add(this.rdbFecha);
            this.gpbCriterio.Controls.Add(this.rdbDoc);
            this.gpbCriterio.Controls.Add(this.rdbId);
            this.gpbCriterio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.gpbCriterio.Location = new System.Drawing.Point(23, 166);
            this.gpbCriterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCriterio.Name = "gpbCriterio";
            this.gpbCriterio.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCriterio.Size = new System.Drawing.Size(689, 153);
            this.gpbCriterio.TabIndex = 30;
            this.gpbCriterio.TabStop = false;
            this.gpbCriterio.Text = "Criterios de busqueda";
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Location = new System.Drawing.Point(501, 106);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(156, 35);
            this.btnRtn.TabIndex = 16;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            this.btnRtn.Click += new System.EventHandler(this.btnRtn_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(261, 114);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 22);
            this.txtBusqueda.TabIndex = 15;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(25, 114);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(196, 19);
            this.lblBusqueda.TabIndex = 14;
            this.lblBusqueda.Text = "Digite criterio de búsqueda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 12;
            // 
            // rdbCed
            // 
            this.rdbCed.AutoSize = true;
            this.rdbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCed.Location = new System.Drawing.Point(173, 50);
            this.rdbCed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbCed.Name = "rdbCed";
            this.rdbCed.Size = new System.Drawing.Size(77, 19);
            this.rdbCed.TabIndex = 4;
            this.rdbCed.TabStop = true;
            this.rdbCed.Text = "Id Cédula";
            this.rdbCed.UseVisualStyleBackColor = true;
            // 
            // rdbResu
            // 
            this.rdbResu.AutoSize = true;
            this.rdbResu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResu.Location = new System.Drawing.Point(568, 50);
            this.rdbResu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbResu.Name = "rdbResu";
            this.rdbResu.Size = new System.Drawing.Size(81, 19);
            this.rdbResu.TabIndex = 3;
            this.rdbResu.TabStop = true;
            this.rdbResu.Text = "Resultado";
            this.rdbResu.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFecha.Location = new System.Drawing.Point(411, 50);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(122, 19);
            this.rdbFecha.TabIndex = 2;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha Evaluación";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbDoc
            // 
            this.rdbDoc.AutoSize = true;
            this.rdbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoc.Location = new System.Drawing.Point(292, 50);
            this.rdbDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDoc.Name = "rdbDoc";
            this.rdbDoc.Size = new System.Drawing.Size(74, 19);
            this.rdbDoc.TabIndex = 1;
            this.rdbDoc.TabStop = true;
            this.rdbDoc.Text = "Id Doctor";
            this.rdbDoc.UseVisualStyleBackColor = true;
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId.Location = new System.Drawing.Point(46, 50);
            this.rdbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(98, 19);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Evaluación";
            this.rdbId.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Interval = 50;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.Lavender;
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
            this.gpbFecha.BackColor = System.Drawing.Color.Lavender;
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
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnca.Location = new System.Drawing.Point(224, 107);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(278, 28);
            this.lblEnca.TabIndex = 34;
            this.lblEnca.Text = "Consulta de Evaluaciones";
            // 
            // FrmConEval08
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConEval08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Consulta de Evaluaciones";
            this.Activated += new System.EventHandler(this.FrmConEval08_Activated);
            this.Load += new System.EventHandler(this.FrmConEval08_Load);
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbCriterio.ResumeLayout(false);
            this.gpbCriterio.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbCriterio;
        private System.Windows.Forms.RadioButton rdbCed;
        private System.Windows.Forms.RadioButton rdbResu;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbDoc;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button btnRtn;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}