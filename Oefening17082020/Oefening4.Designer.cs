namespace Oefening17082020
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.txtDiepte = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lengte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breedte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diepte";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(161, 51);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 22);
            this.txtLengte.TabIndex = 3;
            this.txtLengte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLengte_KeyPress);
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(161, 97);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(100, 22);
            this.txtBreedte.TabIndex = 4;
            this.txtBreedte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreedte_KeyPress);
            // 
            // txtDiepte
            // 
            this.txtDiepte.Location = new System.Drawing.Point(161, 144);
            this.txtDiepte.Name = "txtDiepte";
            this.txtDiepte.Size = new System.Drawing.Size(100, 22);
            this.txtDiepte.TabIndex = 5;
            this.txtDiepte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiepte_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(161, 189);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 51);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiepte);
            this.Controls.Add(this.txtBreedte);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.TextBox txtDiepte;
        private System.Windows.Forms.Button btnCalculate;
    }
}