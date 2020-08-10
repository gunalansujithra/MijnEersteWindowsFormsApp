namespace MijnEersteWindowsFormsApp
{
    partial class OefeningKlas
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtMijnText = new System.Windows.Forms.TextBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(419, 408);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(102, 35);
            this.btnToevoegen.TabIndex = 12;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // txtMijnText
            // 
            this.txtMijnText.Location = new System.Drawing.Point(282, 408);
            this.txtMijnText.Name = "txtMijnText";
            this.txtMijnText.Size = new System.Drawing.Size(120, 22);
            this.txtMijnText.TabIndex = 11;
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.ItemHeight = 16;
            this.lbLeerlingen.Location = new System.Drawing.Point(282, 138);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(179, 244);
            this.lbLeerlingen.TabIndex = 10;
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(282, 54);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(121, 24);
            this.cbLeerlingen.TabIndex = 9;
            this.cbLeerlingen.Text = "--Select--";
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(386, 98);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 8;
            this.btnMijnButton.Text = "Klick Mij";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(279, 7);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(72, 17);
            this.lblMijnLabel.TabIndex = 7;
            this.lblMijnLabel.Text = "Mijn Label";
            // 
            // OefeningKlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtMijnText);
            this.Controls.Add(this.lbLeerlingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.lblMijnLabel);
            this.Name = "OefeningKlas";
            this.Text = "OefeningKlas";
            this.Load += new System.EventHandler(this.OefeningKlas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtMijnText;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.Label lblMijnLabel;
    }
}