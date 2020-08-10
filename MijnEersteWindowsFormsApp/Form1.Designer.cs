namespace MijnEersteWindowsFormsApp
{
    partial class Form1
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
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.txtMijnText = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(65, 48);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(72, 17);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "Mijn Label";
            this.lblMijnLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(172, 139);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(75, 23);
            this.btnMijnButton.TabIndex = 1;
            this.btnMijnButton.Text = "Klick Mij";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.btnMijnButton_Click);
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(68, 95);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(121, 24);
            this.cbLeerlingen.TabIndex = 2;
            this.cbLeerlingen.Text = "--Select--";
            this.cbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.cbLeerlingen_SelectedIndexChanged);
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.ItemHeight = 16;
            this.lbLeerlingen.Location = new System.Drawing.Point(68, 179);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(179, 244);
            this.lbLeerlingen.TabIndex = 3;
            // 
            // txtMijnText
            // 
            this.txtMijnText.Location = new System.Drawing.Point(68, 449);
            this.txtMijnText.Name = "txtMijnText";
            this.txtMijnText.Size = new System.Drawing.Size(120, 22);
            this.txtMijnText.TabIndex = 5;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(205, 449);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(102, 35);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtMijnText);
            this.Controls.Add(this.lbLeerlingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.lblMijnLabel);
            this.Name = "Form1";
            this.Text = "Mijn App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.TextBox txtMijnText;
        private System.Windows.Forms.Button btnToevoegen;
    }
}

