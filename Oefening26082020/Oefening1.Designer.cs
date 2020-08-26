namespace Oefening26082020
{
    partial class Oefening1
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
            this.cbNummers = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNummers
            // 
            this.cbNummers.FormattingEnabled = true;
            this.cbNummers.Location = new System.Drawing.Point(101, 56);
            this.cbNummers.Name = "cbNummers";
            this.cbNummers.Size = new System.Drawing.Size(183, 24);
            this.cbNummers.TabIndex = 0;
            this.cbNummers.SelectedIndexChanged += new System.EventHandler(this.cbNummers_SelectedIndexChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(101, 107);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(46, 17);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "label1";
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.cbNummers);
            this.Name = "Oefening1";
            this.Text = "Oefening1";
            this.Load += new System.EventHandler(this.Oefening1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNummers;
        private System.Windows.Forms.Label lblDisplay;
    }
}