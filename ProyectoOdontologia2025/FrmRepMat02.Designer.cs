namespace ProyectoOdontologia2025
{
    partial class FrmRepMat02
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.gpbTabla = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gpbGrafico = new System.Windows.Forms.GroupBox();
            this.chartMateriales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTipoGraf = new System.Windows.Forms.Label();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.btnRtn = new System.Windows.Forms.Button();
            this.gpbTitulo.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.gpbTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // gpbTitulo
            // 
            this.gpbTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbTitulo.Controls.Add(this.lblnom1);
            this.gpbTitulo.Controls.Add(this.lblnom);
            this.gpbTitulo.Location = new System.Drawing.Point(9, 10);
            this.gpbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.gpbTitulo.Name = "gpbTitulo";
            this.gpbTitulo.Size = new System.Drawing.Size(197, 78);
            this.gpbTitulo.TabIndex = 0;
            this.gpbTitulo.TabStop = false;
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblnom1.ForeColor = System.Drawing.Color.White;
            this.lblnom1.Location = new System.Drawing.Point(13, 45);
            this.lblnom1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(164, 19);
            this.lblnom1.TabIndex = 0;
            this.lblnom1.Text = "Politécnico Las Mercedes";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(7, 21);
            this.lblnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(183, 19);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Consultorio Odontológico";
            // 
            // gpbFecha
            // 
            this.gpbFecha.BackColor = System.Drawing.Color.MediumPurple;
            this.gpbFecha.Controls.Add(this.lblhora2);
            this.gpbFecha.Controls.Add(this.lblfecha2);
            this.gpbFecha.Controls.Add(this.lblhora);
            this.gpbFecha.Controls.Add(this.lblfecha);
            this.gpbFecha.Location = new System.Drawing.Point(570, 10);
            this.gpbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(165, 78);
            this.gpbFecha.TabIndex = 1;
            this.gpbFecha.TabStop = false;
            // 
            // lblhora2
            // 
            this.lblhora2.BackColor = System.Drawing.Color.White;
            this.lblhora2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lblhora2.Location = new System.Drawing.Point(75, 45);
            this.lblhora2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhora2.Name = "lblhora2";
            this.lblhora2.Size = new System.Drawing.Size(79, 19);
            this.lblhora2.TabIndex = 0;
            // 
            // lblfecha2
            // 
            this.lblfecha2.BackColor = System.Drawing.Color.White;
            this.lblfecha2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lblfecha2.Location = new System.Drawing.Point(75, 16);
            this.lblfecha2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(79, 19);
            this.lblfecha2.TabIndex = 1;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(8, 45);
            this.lblhora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(42, 19);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "Hora:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(8, 16);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 19);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "Fecha:";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlDivision.Location = new System.Drawing.Point(0, 98);
            this.pnlDivision.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(758, 3);
            this.pnlDivision.TabIndex = 2;
            // 
            // lblEnca
            // 
            this.lblEnca.AutoSize = true;
            this.lblEnca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEnca.ForeColor = System.Drawing.Color.Indigo;
            this.lblEnca.Location = new System.Drawing.Point(221, 34);
            this.lblEnca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnca.Name = "lblEnca";
            this.lblEnca.Size = new System.Drawing.Size(245, 28);
            this.lblEnca.TabIndex = 3;
            this.lblEnca.Text = "Reporte de Materiales";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.btnPDF);
            this.pnlFiltros.Controls.Add(this.btnImprimir);
            this.pnlFiltros.Controls.Add(this.btnExportar);
            this.pnlFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.pnlFiltros.Controls.Add(this.lblResumen);
            this.pnlFiltros.Location = new System.Drawing.Point(9, 107);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(726, 34);
            this.pnlFiltros.TabIndex = 3;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPDF.Location = new System.Drawing.Point(645, 6);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 21);
            this.btnPDF.TabIndex = 5;
            this.btnPDF.Text = "📄 PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnImprimir.Location = new System.Drawing.Point(555, 6);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 21);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "🖨️ Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExportar.Location = new System.Drawing.Point(465, 6);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(85, 21);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "📥 Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.Indigo;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(365, 6);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(95, 21);
            this.btnLimpiarFiltros.TabIndex = 1;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumen.ForeColor = System.Drawing.Color.Indigo;
            this.lblResumen.Location = new System.Drawing.Point(10, 10);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(362, 17);
            this.lblResumen.TabIndex = 2;
            this.lblResumen.Text = "Materiales: 0   |   Cantidad Total: 0   |   Valor Total: $0.00  ";
            // 
            // gpbTabla
            // 
            this.gpbTabla.Controls.Add(this.dgvDatos);
            this.gpbTabla.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.gpbTabla.ForeColor = System.Drawing.Color.Indigo;
            this.gpbTabla.Location = new System.Drawing.Point(9, 148);
            this.gpbTabla.Margin = new System.Windows.Forms.Padding(2);
            this.gpbTabla.Name = "gpbTabla";
            this.gpbTabla.Size = new System.Drawing.Size(726, 244);
            this.gpbTabla.TabIndex = 4;
            this.gpbTabla.TabStop = false;
            this.gpbTabla.Text = "Inventario de Materiales";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(3, 18);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(720, 223);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatos_ColumnHeaderMouseClick);
            // 
            // gpbGrafico
            // 
            this.gpbGrafico.Controls.Add(this.chartMateriales);
            this.gpbGrafico.Controls.Add(this.lblTipoGraf);
            this.gpbGrafico.Controls.Add(this.cmbTipoGrafico);
            this.gpbGrafico.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.gpbGrafico.ForeColor = System.Drawing.Color.Indigo;
            this.gpbGrafico.Location = new System.Drawing.Point(9, 400);
            this.gpbGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.gpbGrafico.Name = "gpbGrafico";
            this.gpbGrafico.Size = new System.Drawing.Size(726, 332);
            this.gpbGrafico.TabIndex = 5;
            this.gpbGrafico.TabStop = false;
            this.gpbGrafico.Text = "Gráfico";
            // 
            // chartMateriales
            // 
            this.chartMateriales.BackColor = System.Drawing.Color.Transparent;
            chartArea.Name = "AreaPrincipal";
            this.chartMateriales.ChartAreas.Add(chartArea);
            this.chartMateriales.Location = new System.Drawing.Point(3, 37);
            this.chartMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.chartMateriales.Name = "chartMateriales";
            this.chartMateriales.Size = new System.Drawing.Size(718, 278);
            this.chartMateriales.TabIndex = 0;
            // 
            // lblTipoGraf
            // 
            this.lblTipoGraf.AutoSize = true;
            this.lblTipoGraf.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lblTipoGraf.ForeColor = System.Drawing.Color.Indigo;
            this.lblTipoGraf.Location = new System.Drawing.Point(4, 16);
            this.lblTipoGraf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoGraf.Name = "lblTipoGraf";
            this.lblTipoGraf.Size = new System.Drawing.Size(89, 16);
            this.lblTipoGraf.TabIndex = 1;
            this.lblTipoGraf.Text = "Tipo de gráfico:";
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGrafico.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.cmbTipoGrafico.Items.AddRange(new object[] {
            "Barras Horizontales",
            "Barras Verticales",
            "Pastel",
            "Dona"});
            this.cmbTipoGrafico.Location = new System.Drawing.Point(97, 13);
            this.cmbTipoGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoGrafico.TabIndex = 2;
            this.cmbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafico_SelectedIndexChanged);
            // 
            // btnRtn
            // 
            this.btnRtn.BackColor = System.Drawing.Color.Lavender;
            this.btnRtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRtn.ForeColor = System.Drawing.Color.Indigo;
            this.btnRtn.Location = new System.Drawing.Point(648, 736);
            this.btnRtn.Margin = new System.Windows.Forms.Padding(2);
            this.btnRtn.Name = "btnRtn";
            this.btnRtn.Size = new System.Drawing.Size(90, 29);
            this.btnRtn.TabIndex = 6;
            this.btnRtn.Text = "Retornar";
            this.btnRtn.UseVisualStyleBackColor = false;
            this.btnRtn.Click += new System.EventHandler(this.btnRtn_Click);
            // 
            // FrmRepMat02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 793);
            this.Controls.Add(this.gpbTitulo);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.lblEnca);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.gpbTabla);
            this.Controls.Add(this.gpbGrafico);
            this.Controls.Add(this.btnRtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRepMat02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Materiales";
            this.Load += new System.EventHandler(this.FrmRepMat02_Load);
            this.gpbTitulo.ResumeLayout(false);
            this.gpbTitulo.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.gpbTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbGrafico.ResumeLayout(false);
            this.gpbGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.GroupBox gpbTitulo;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.GroupBox gpbFecha;
        private System.Windows.Forms.Label lblhora2;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.Label lblEnca;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.GroupBox gpbTabla;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbGrafico;
        private System.Windows.Forms.Label lblTipoGraf;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMateriales;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnRtn;
    }
}