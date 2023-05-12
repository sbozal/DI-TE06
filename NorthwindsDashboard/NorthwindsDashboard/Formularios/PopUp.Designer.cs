namespace NorthwindsDashboard.Formularios
{
    partial class PopUp
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
            this.tbPopUp = new System.Windows.Forms.TextBox();
            this.btnPopUp = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // tbPopUp
            // 
            this.tbPopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.tbPopUp, "Información: Importe Ventas");
            this.tbPopUp.Location = new System.Drawing.Point(12, 12);
            this.tbPopUp.Margin = new System.Windows.Forms.Padding(20);
            this.tbPopUp.Multiline = true;
            this.tbPopUp.Name = "tbPopUp";
            this.tbPopUp.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.tbPopUp, true);
            this.tbPopUp.Size = new System.Drawing.Size(427, 114);
            this.tbPopUp.TabIndex = 0;
            // 
            // btnPopUp
            // 
            this.helpProvider1.SetHelpString(this.btnPopUp, "Cerrar PopUp");
            this.btnPopUp.Location = new System.Drawing.Point(311, 132);
            this.btnPopUp.Name = "btnPopUp";
            this.helpProvider1.SetShowHelp(this.btnPopUp, true);
            this.btnPopUp.Size = new System.Drawing.Size(128, 23);
            this.btnPopUp.TabIndex = 1;
            this.btnPopUp.Text = "Cerrar";
            this.btnPopUp.UseVisualStyleBackColor = true;
            this.btnPopUp.Click += new System.EventHandler(this.btnPopUp_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 166);
            this.Controls.Add(this.btnPopUp);
            this.Controls.Add(this.tbPopUp);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Load += new System.EventHandler(this.PopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPopUp;
        private System.Windows.Forms.Button btnPopUp;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}