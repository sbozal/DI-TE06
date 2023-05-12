namespace NorthwindsDashboard
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tbFacturacionInfo = new System.Windows.Forms.TextBox();
            this.tbEmpleadoInfo = new System.Windows.Forms.TextBox();
            this.tbClienteInfo = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tbProductoInfo = new System.Windows.Forms.TextBox();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.bCrystal = new System.Windows.Forms.Button();
            this.bViewer = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tlpGraficosBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlfGraficosIzq = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTartas = new System.Windows.Forms.TableLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tpBotonCrystal = new System.Windows.Forms.ToolTip(this.components);
            this.tpBotonRV = new System.Windows.Forms.ToolTip(this.components);
            this.tpAño = new System.Windows.Forms.ToolTip(this.components);
            this.tpPais = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBase.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tlpGraficosBase.SuspendLayout();
            this.tlfGraficosIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44444F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.55556F));
            this.tlpBase.Controls.Add(this.tlpFiltros, 1, 0);
            this.tlpBase.Controls.Add(this.tlpInfo, 0, 1);
            this.tlpBase.Controls.Add(this.tlpGraficosBase, 1, 1);
            this.tlpBase.Controls.Add(this.logo, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.97174F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.02826F));
            this.tlpBase.Size = new System.Drawing.Size(1162, 708);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tlpFiltros.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFiltros.Controls.Add(this.cbPais, 1, 1);
            this.tlpFiltros.Controls.Add(this.labelPais, 1, 0);
            this.tlpFiltros.Controls.Add(this.labelYear, 0, 0);
            this.tlpFiltros.Controls.Add(this.cbYear, 0, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(228, 3);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 2;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpFiltros.Size = new System.Drawing.Size(931, 92);
            this.tlpFiltros.TabIndex = 0;
            this.tlpFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpFiltros_Paint);
            // 
            // cbPais
            // 
            this.cbPais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(517, 54);
            this.cbPais.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(200, 21);
            this.cbPais.TabIndex = 3;
            this.cbPais.Text = "Todos";
            this.cbPais.SelectionChangeCommitted += new System.EventHandler(this.cbPais_SelectionChangeCommitted);
            // 
            // labelPais
            // 
            this.labelPais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPais.Location = new System.Drawing.Point(517, 9);
            this.labelPais.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(45, 22);
            this.labelPais.TabIndex = 1;
            this.labelPais.Text = "País:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(53, 9);
            this.labelYear.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(46, 22);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Año:";
            // 
            // cbYear
            // 
            this.cbYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(53, 54);
            this.cbYear.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(200, 21);
            this.cbYear.TabIndex = 2;
            this.cbYear.Text = "Todos";
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            this.cbYear.SelectionChangeCommitted += new System.EventHandler(this.cbYear_SelectionChangeCommitted);
            // 
            // tlpInfo
            // 
            this.tlpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tlpInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.tbFacturacionInfo, 0, 4);
            this.tlpInfo.Controls.Add(this.tbEmpleadoInfo, 0, 3);
            this.tlpInfo.Controls.Add(this.tbClienteInfo, 0, 2);
            this.tlpInfo.Controls.Add(this.labelInfo, 0, 0);
            this.tlpInfo.Controls.Add(this.tbProductoInfo, 0, 1);
            this.tlpInfo.Controls.Add(this.tlpBotones, 0, 5);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 101);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 6;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpInfo.Size = new System.Drawing.Size(219, 604);
            this.tlpInfo.TabIndex = 1;
            this.tlpInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpInfo_Paint);
            // 
            // tbFacturacionInfo
            // 
            this.tbFacturacionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tbFacturacionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFacturacionInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacturacionInfo.Location = new System.Drawing.Point(6, 412);
            this.tbFacturacionInfo.Multiline = true;
            this.tbFacturacionInfo.Name = "tbFacturacionInfo";
            this.tbFacturacionInfo.ReadOnly = true;
            this.tbFacturacionInfo.Size = new System.Drawing.Size(204, 71);
            this.tbFacturacionInfo.TabIndex = 4;
            // 
            // tbEmpleadoInfo
            // 
            this.tbEmpleadoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tbEmpleadoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmpleadoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmpleadoInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleadoInfo.Location = new System.Drawing.Point(6, 293);
            this.tbEmpleadoInfo.Multiline = true;
            this.tbEmpleadoInfo.Name = "tbEmpleadoInfo";
            this.tbEmpleadoInfo.ReadOnly = true;
            this.tbEmpleadoInfo.Size = new System.Drawing.Size(207, 110);
            this.tbEmpleadoInfo.TabIndex = 3;
            // 
            // tbClienteInfo
            // 
            this.tbClienteInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tbClienteInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClienteInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClienteInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClienteInfo.Location = new System.Drawing.Point(6, 174);
            this.tbClienteInfo.Multiline = true;
            this.tbClienteInfo.Name = "tbClienteInfo";
            this.tbClienteInfo.ReadOnly = true;
            this.tbClienteInfo.Size = new System.Drawing.Size(207, 110);
            this.tbClienteInfo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(43, 13);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(40, 10, 3, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(170, 36);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Información:";
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // tbProductoInfo
            // 
            this.tbProductoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tbProductoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProductoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProductoInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductoInfo.Location = new System.Drawing.Point(6, 55);
            this.tbProductoInfo.Multiline = true;
            this.tbProductoInfo.Name = "tbProductoInfo";
            this.tbProductoInfo.ReadOnly = true;
            this.tbProductoInfo.Size = new System.Drawing.Size(207, 110);
            this.tbProductoInfo.TabIndex = 1;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.Controls.Add(this.bCrystal, 0, 0);
            this.tlpBotones.Controls.Add(this.bViewer, 0, 1);
            this.tlpBotones.Controls.Add(this.btnInfo, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(6, 531);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(207, 67);
            this.tlpBotones.TabIndex = 5;
            // 
            // bCrystal
            // 
            this.bCrystal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCrystal.Location = new System.Drawing.Point(3, 3);
            this.bCrystal.Name = "bCrystal";
            this.bCrystal.Size = new System.Drawing.Size(159, 27);
            this.bCrystal.TabIndex = 0;
            this.bCrystal.Text = "Generar Informe";
            this.bCrystal.UseVisualStyleBackColor = true;
            this.bCrystal.Click += new System.EventHandler(this.bCrystal_Click);
            // 
            // bViewer
            // 
            this.bViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bViewer.Location = new System.Drawing.Point(3, 36);
            this.bViewer.Name = "bViewer";
            this.bViewer.Size = new System.Drawing.Size(159, 28);
            this.bViewer.TabIndex = 1;
            this.bViewer.Text = "ReportViewer";
            this.bViewer.UseVisualStyleBackColor = true;
            this.bViewer.Click += new System.EventHandler(this.bViewer_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfo.Location = new System.Drawing.Point(168, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(36, 27);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tlpGraficosBase
            // 
            this.tlpGraficosBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.tlpGraficosBase.ColumnCount = 2;
            this.tlpGraficosBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82183F));
            this.tlpGraficosBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17817F));
            this.tlpGraficosBase.Controls.Add(this.tlfGraficosIzq, 0, 0);
            this.tlpGraficosBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraficosBase.Location = new System.Drawing.Point(225, 98);
            this.tlpGraficosBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGraficosBase.Name = "tlpGraficosBase";
            this.tlpGraficosBase.RowCount = 1;
            this.tlpGraficosBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraficosBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tlpGraficosBase.Size = new System.Drawing.Size(937, 610);
            this.tlpGraficosBase.TabIndex = 2;
            // 
            // tlfGraficosIzq
            // 
            this.tlfGraficosIzq.ColumnCount = 1;
            this.tlfGraficosIzq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlfGraficosIzq.Controls.Add(this.tlpTartas, 0, 0);
            this.tlfGraficosIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlfGraficosIzq.Location = new System.Drawing.Point(0, 0);
            this.tlfGraficosIzq.Margin = new System.Windows.Forms.Padding(0);
            this.tlfGraficosIzq.Name = "tlfGraficosIzq";
            this.tlfGraficosIzq.RowCount = 2;
            this.tlfGraficosIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.91621F));
            this.tlfGraficosIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.08379F));
            this.tlfGraficosIzq.Size = new System.Drawing.Size(588, 610);
            this.tlfGraficosIzq.TabIndex = 0;
            // 
            // tlpTartas
            // 
            this.tlpTartas.ColumnCount = 2;
            this.tlpTartas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTartas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTartas.Location = new System.Drawing.Point(0, 0);
            this.tlpTartas.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTartas.Name = "tlpTartas";
            this.tlpTartas.RowCount = 1;
            this.tlpTartas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTartas.Size = new System.Drawing.Size(588, 328);
            this.tlpTartas.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logo.ErrorImage")));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(219, 92);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 708);
            this.Controls.Add(this.tlpBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dashboard NorthWinds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpBase.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tlpGraficosBase.ResumeLayout(false);
            this.tlfGraficosIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpGraficosBase;
        private System.Windows.Forms.TableLayoutPanel tlfGraficosIzq;
        private System.Windows.Forms.TableLayoutPanel tlpTartas;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox tbFacturacionInfo;
        private System.Windows.Forms.TextBox tbEmpleadoInfo;
        private System.Windows.Forms.TextBox tbClienteInfo;
        private System.Windows.Forms.TextBox tbProductoInfo;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button bCrystal;
        private System.Windows.Forms.Button bViewer;
        private System.Windows.Forms.ToolTip tpBotonCrystal;
        private System.Windows.Forms.ToolTip tpBotonRV;
        private System.Windows.Forms.ToolTip tpAño;
        private System.Windows.Forms.ToolTip tpPais;
        private System.Windows.Forms.Button btnInfo;
    }
}

