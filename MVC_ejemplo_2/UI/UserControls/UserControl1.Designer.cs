namespace UI.UserControls
{
    partial class UserControl1
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
            this.cbSeleccion = new System.Windows.Forms.ComboBox();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbSeleccion
            // 
            this.cbSeleccion.FormattingEnabled = true;
            this.cbSeleccion.Location = new System.Drawing.Point(95, 55);
            this.cbSeleccion.Name = "cbSeleccion";
            this.cbSeleccion.Size = new System.Drawing.Size(347, 24);
            this.cbSeleccion.TabIndex = 0;
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(493, 55);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(157, 24);
            this.btnEnvio.TabIndex = 1;
            this.btnEnvio.Text = "Enviar";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.cbSeleccion);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(819, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSeleccion;
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.TextBox textBox1;
    }
}
