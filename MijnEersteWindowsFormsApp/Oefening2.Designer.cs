namespace MijnEersteWindowsFormsApp
{
    partial class Oefening2
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
            this.cbMijnCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMijnCombo
            // 
            this.cbMijnCombo.FormattingEnabled = true;
            this.cbMijnCombo.Location = new System.Drawing.Point(95, 73);
            this.cbMijnCombo.Name = "cbMijnCombo";
            this.cbMijnCombo.Size = new System.Drawing.Size(334, 24);
            this.cbMijnCombo.TabIndex = 0;
            this.cbMijnCombo.SelectedIndexChanged += new System.EventHandler(this.cbMijnCombo_SelectedIndexChanged);
            this.cbMijnCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMijnCombo_MouseClick);
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMijnCombo);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMijnCombo;
    }
}