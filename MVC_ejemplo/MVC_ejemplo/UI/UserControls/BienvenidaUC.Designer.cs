namespace UI.UserControls
{
    partial class BienvenidaUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLP_Bienvenida_Base = new System.Windows.Forms.TableLayoutPanel();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.tLP_Bienvenida_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Bienvenida_Base
            // 
            this.tLP_Bienvenida_Base.ColumnCount = 1;
            this.tLP_Bienvenida_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Bienvenida_Base.Controls.Add(this.labelBienvenida, 0, 0);
            this.tLP_Bienvenida_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Bienvenida_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Bienvenida_Base.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Bienvenida_Base.Name = "tLP_Bienvenida_Base";
            this.tLP_Bienvenida_Base.RowCount = 1;
            this.tLP_Bienvenida_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Bienvenida_Base.Size = new System.Drawing.Size(1761, 953);
            this.tLP_Bienvenida_Base.TabIndex = 0;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(5, 0);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(2191, 1191);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido a tu Dashboard";
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BienvenidaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLP_Bienvenida_Base);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BienvenidaUC";
            this.Size = new System.Drawing.Size(1761, 953);
            this.tLP_Bienvenida_Base.ResumeLayout(false);
            this.tLP_Bienvenida_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Bienvenida_Base;
        private System.Windows.Forms.Label labelBienvenida;
    }
}
