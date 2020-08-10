namespace MijnEersteWindowsFormsApp
{
    partial class Oefening3
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
            this.lbNaam = new System.Windows.Forms.ListBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNaam
            // 
            this.lbNaam.FormattingEnabled = true;
            this.lbNaam.ItemHeight = 16;
            this.lbNaam.Location = new System.Drawing.Point(72, 40);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(270, 228);
            this.lbNaam.TabIndex = 0;
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(72, 321);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(120, 22);
            this.txtLetter.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(260, 321);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(168, 35);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lbNaam);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.Load += new System.EventHandler(this.Oefening3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNaam;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnEnter;
    }
}