namespace Oefening26082020
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
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnKlik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(216, 96);
            this.nudNumber.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(278, 22);
            this.nudNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Number";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(84, 224);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(46, 17);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "label2";
            // 
            // btnKlik
            // 
            this.btnKlik.Location = new System.Drawing.Point(509, 90);
            this.btnKlik.Name = "btnKlik";
            this.btnKlik.Size = new System.Drawing.Size(99, 36);
            this.btnKlik.TabIndex = 3;
            this.btnKlik.Text = "Klik";
            this.btnKlik.UseVisualStyleBackColor = true;
            this.btnKlik.Click += new System.EventHandler(this.btnKlik_Click);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKlik);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumber);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnKlik;
    }
}