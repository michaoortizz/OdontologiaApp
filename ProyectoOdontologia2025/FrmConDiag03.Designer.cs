namespace ProyectoOdontologia2025
{
    partial class FrmConDiag03
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbCriterios = new System.Windows.Forms.GroupBox();
            this.btnRtn = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbCed = new System.Windows.Forms.RadioButton();
            this.rdbDoc = new System.Windows.Forms.RadioButton();
            this.rdbFe = new System.Windows.Forms.RadioButton();
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
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbCriterios.SuspendLayout();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.dgvDatos);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(23, 347);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatos.Size = new System.Drawing.Size(689, 172);
            this.gpbDatos.TabIndex = 21;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Resultado de búsqueda";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(46, 28);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(604, 131);
            this.dgvDatos.TabIndex = 0;
            // 
            // gpbCriterios
            // 
            this.gpbCriterios.BackColor = System.Drawing.Color.Lavender;
            this.gpbCriterios.Controls.Add(this.btnRtn);
            this.gpbCriterios.Controls.Add(this.txtBusqueda);
            this.gpbCriterios.Controls.Add(this.lblBusqueda);
            this.gpbCriterios.Controls.Add(this.rdbDesc);
            this.gpbCriterios.Controls.Add(this.rdbCed);
            this.gpbCriterios.Controls.Add(this.rdbDoc);
            this.gpbCriterios.Controls.Add(this.rdbFe);
            this.gpbCriterios.Controls.Add(this.rdbId);
            this.gpbCriterios.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCriterios.Location = new System.Drawing.Point(23, 171);
            this.gpbCriterios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCriterios.Name = "gpbCriterios";
            this.gpbCriterios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbCriterios.Size = new System.Drawing.Size(689, 142);
            this.gpbCriterios.TabIndex = 20;
            this.gpbCriterios.TabStop = false;
            this.gpbCriterios.Text = "Criterios de busqueda";
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Location = new System.Drawing.Point(494, 95);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(156, 35);
            this.btnRtn.TabIndex = 31;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            this.btnRtn.Click += new System.EventHandler(this.btnRtn_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(253, 102);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(148, 22);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(17, 102);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(196, 19);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Digite criterio de búsqueda:";
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDesc.Location = new System.Drawing.Point(529, 45);
            this.rdbDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(90, 19);
            this.rdbDesc.TabIndex = 4;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "Descripción";
            this.rdbDesc.UseVisualStyleBackColor = true;
            // 
            // rdbCed
            // 
            this.rdbCed.AutoSize = true;
            this.rdbCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCed.Location = new System.Drawing.Point(168, 45);
            this.rdbCed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbCed.Name = "rdbCed";
            this.rdbCed.Size = new System.Drawing.Size(77, 19);
            this.rdbCed.TabIndex = 3;
            this.rdbCed.TabStop = true;
            this.rdbCed.Text = "Id Cédula";
            this.rdbCed.UseVisualStyleBackColor = true;
            // 
            // rdbDoc
            // 
            this.rdbDoc.AutoSize = true;
            this.rdbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoc.Location = new System.Drawing.Point(292, 45);
            this.rdbDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDoc.Name = "rdbDoc";
            this.rdbDoc.Size = new System.Drawing.Size(74, 19);
            this.rdbDoc.TabIndex = 2;
            this.rdbDoc.TabStop = true;
            this.rdbDoc.Text = "Id Doctor";
            this.rdbDoc.UseVisualStyleBackColor = true;
            // 
            // rdbFe
            // 
            this.rdbFe.AutoSize = true;
            this.rdbFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFe.Location = new System.Drawing.Point(411, 45);
            this.rdbFe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFe.Name = "rdbFe";
            this.rdbFe.Size = new System.Drawing.Size(59, 19);
            this.rdbFe.TabIndex = 1;
            this.rdbFe.TabStop = true;
            this.rdbFe.Text = "Fecha";
            this.rdbFe.UseVisualStyleBackColor = true;
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId.Location = new System.Drawing.Point(46, 45);
            this.rdbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(103, 19);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Diagnóstico";
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
            this.gpbTitulo.TabIndex = 28;
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
            this.gpbFecha.TabIndex = 29;
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
            this.lblEnca.Location = new System.Drawing.Point(227, 112);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(280, 28);
            this.lblEnca.TabIndex = 30;
            this.lblEnca.Text = "Consulta de Diagnósticos";
            // 
            // FrmConDiag03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(741, 530);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.gpbCriterios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConDiag03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Consultas de Diágnosticos";
            this.Activated += new System.EventHandler(this.FrmConDiag03_Activated);
            this.Load += new System.EventHandler(this.FrmConDiag03_Load);
            this.gpbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbCriterios.ResumeLayout(false);
            this.gpbCriterios.PerformLayout();
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbCriterios;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbCed;
        private System.Windows.Forms.RadioButton rdbDoc;
        private System.Windows.Forms.RadioButton rdbFe;
        private System.Windows.Forms.RadioButton rdbId;
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
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnRtn;
    }
}