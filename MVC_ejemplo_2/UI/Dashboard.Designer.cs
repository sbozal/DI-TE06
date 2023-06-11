namespace UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tlp_Dashboard = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Imagen = new System.Windows.Forms.Panel();
            this.panel_ParteArriba = new System.Windows.Forms.Panel();
            this.panel_Datos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlp_Dashboard.SuspendLayout();
            this.panel_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Dashboard
            // 
            this.tlp_Dashboard.ColumnCount = 2;
            this.tlp_Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.07904F));
            this.tlp_Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.92096F));
            this.tlp_Dashboard.Controls.Add(this.panel_Imagen, 0, 0);
            this.tlp_Dashboard.Controls.Add(this.panel_ParteArriba, 1, 0);
            this.tlp_Dashboard.Controls.Add(this.panel_Datos, 1, 1);
            this.tlp_Dashboard.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlp_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.tlp_Dashboard.Name = "tlp_Dashboard";
            this.tlp_Dashboard.RowCount = 2;
            this.tlp_Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47601F));
            this.tlp_Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.52399F));
            this.tlp_Dashboard.Size = new System.Drawing.Size(1164, 759);
            this.tlp_Dashboard.TabIndex = 0;
            // 
            // panel_Imagen
            // 
            this.panel_Imagen.BackColor = System.Drawing.Color.LightGray;
            this.panel_Imagen.Controls.Add(this.pictureBox1);
            this.panel_Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Imagen.Location = new System.Drawing.Point(3, 3);
            this.panel_Imagen.Name = "panel_Imagen";
            this.panel_Imagen.Size = new System.Drawing.Size(251, 88);
            this.panel_Imagen.TabIndex = 0;
            // 
            // panel_ParteArriba
            // 
            this.panel_ParteArriba.AutoSize = true;
            this.panel_ParteArriba.BackColor = System.Drawing.Color.LightGray;
            this.panel_ParteArriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ParteArriba.Location = new System.Drawing.Point(260, 3);
            this.panel_ParteArriba.Name = "panel_ParteArriba";
            this.panel_ParteArriba.Size = new System.Drawing.Size(901, 88);
            this.panel_ParteArriba.TabIndex = 2;
            // 
            // panel_Datos
            // 
            this.panel_Datos.AutoSize = true;
            this.panel_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Datos.Location = new System.Drawing.Point(267, 104);
            this.panel_Datos.Margin = new System.Windows.Forms.Padding(10);
            this.panel_Datos.Name = "panel_Datos";
            this.panel_Datos.Size = new System.Drawing.Size(887, 645);
            this.panel_Datos.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 659);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 759);
            this.Controls.Add(this.tlp_Dashboard);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tlp_Dashboard.ResumeLayout(false);
            this.tlp_Dashboard.PerformLayout();
            this.panel_Imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Dashboard;
        private System.Windows.Forms.Panel panel_Imagen;
        private System.Windows.Forms.Panel panel_ParteArriba;
        private System.Windows.Forms.Panel panel_Datos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}