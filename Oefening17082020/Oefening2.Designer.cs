namespace Oefening17082020
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
            this.btnVolPlus = new System.Windows.Forms.Button();
            this.btnVolMin = new System.Windows.Forms.Button();
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.btnKanaalMin = new System.Windows.Forms.Button();
            this.btnKanaalPlus = new System.Windows.Forms.Button();
            this.txtKanaal = new System.Windows.Forms.TextBox();
            this.btnKanaal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolPlus
            // 
            this.btnVolPlus.Location = new System.Drawing.Point(78, 35);
            this.btnVolPlus.Name = "btnVolPlus";
            this.btnVolPlus.Size = new System.Drawing.Size(225, 47);
            this.btnVolPlus.TabIndex = 0;
            this.btnVolPlus.Text = "Volume +";
            this.btnVolPlus.UseVisualStyleBackColor = true;
            this.btnVolPlus.Click += new System.EventHandler(this.btnVolPlus_Click);
            // 
            // btnVolMin
            // 
            this.btnVolMin.Location = new System.Drawing.Point(78, 109);
            this.btnVolMin.Name = "btnVolMin";
            this.btnVolMin.Size = new System.Drawing.Size(225, 47);
            this.btnVolMin.TabIndex = 1;
            this.btnVolMin.Text = "Volume -";
            this.btnVolMin.UseVisualStyleBackColor = true;
            this.btnVolMin.Click += new System.EventHandler(this.btnVolMin_Click);
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Location = new System.Drawing.Point(75, 398);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(46, 17);
            this.lblDisplayText.TabIndex = 2;
            this.lblDisplayText.Text = "label1";
            // 
            // btnKanaalMin
            // 
            this.btnKanaalMin.Location = new System.Drawing.Point(78, 252);
            this.btnKanaalMin.Name = "btnKanaalMin";
            this.btnKanaalMin.Size = new System.Drawing.Size(225, 47);
            this.btnKanaalMin.TabIndex = 3;
            this.btnKanaalMin.Text = "Kanaal -";
            this.btnKanaalMin.UseVisualStyleBackColor = true;
            this.btnKanaalMin.Click += new System.EventHandler(this.btnKanaalMin_Click);
            // 
            // btnKanaalPlus
            // 
            this.btnKanaalPlus.Location = new System.Drawing.Point(78, 180);
            this.btnKanaalPlus.Name = "btnKanaalPlus";
            this.btnKanaalPlus.Size = new System.Drawing.Size(225, 47);
            this.btnKanaalPlus.TabIndex = 4;
            this.btnKanaalPlus.Text = "Kanaal +";
            this.btnKanaalPlus.UseVisualStyleBackColor = true;
            this.btnKanaalPlus.Click += new System.EventHandler(this.btnKanaalPlus_Click);
            // 
            // txtKanaal
            // 
            this.txtKanaal.Location = new System.Drawing.Point(78, 336);
            this.txtKanaal.MaxLength = 1;
            this.txtKanaal.Name = "txtKanaal";
            this.txtKanaal.Size = new System.Drawing.Size(100, 22);
            this.txtKanaal.TabIndex = 5;
            this.txtKanaal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKanaal_KeyPress);
            // 
            // btnKanaal
            // 
            this.btnKanaal.Location = new System.Drawing.Point(205, 323);
            this.btnKanaal.Name = "btnKanaal";
            this.btnKanaal.Size = new System.Drawing.Size(98, 48);
            this.btnKanaal.TabIndex = 6;
            this.btnKanaal.Text = "View Kanaal";
            this.btnKanaal.UseVisualStyleBackColor = true;
            this.btnKanaal.Click += new System.EventHandler(this.btnKanaal_Click);
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKanaal);
            this.Controls.Add(this.txtKanaal);
            this.Controls.Add(this.btnKanaalPlus);
            this.Controls.Add(this.btnKanaalMin);
            this.Controls.Add(this.lblDisplayText);
            this.Controls.Add(this.btnVolMin);
            this.Controls.Add(this.btnVolPlus);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolPlus;
        private System.Windows.Forms.Button btnVolMin;
        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.Button btnKanaalMin;
        private System.Windows.Forms.Button btnKanaalPlus;
        private System.Windows.Forms.TextBox txtKanaal;
        private System.Windows.Forms.Button btnKanaal;
    }
}