namespace MijnEersteWindowsFormsApp
{
    partial class Oefening4
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
            this.cbNaam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbNaam
            // 
            this.cbNaam.FormattingEnabled = true;
            this.cbNaam.Location = new System.Drawing.Point(97, 74);
            this.cbNaam.Name = "cbNaam";
            this.cbNaam.Size = new System.Drawing.Size(334, 24);
            this.cbNaam.TabIndex = 0;
            this.cbNaam.SelectedIndexChanged += new System.EventHandler(this.cbNaam_SelectedIndexChanged);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNaam);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            this.Load += new System.EventHandler(this.Oefening4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNaam;
    }
}