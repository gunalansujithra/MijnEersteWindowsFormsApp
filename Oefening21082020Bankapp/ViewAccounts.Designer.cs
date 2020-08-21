namespace Oefening21082020Bankapp
{
    partial class ViewAccounts
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
            this.lbType = new System.Windows.Forms.ListBox();
            this.lbRekening = new System.Windows.Forms.ListBox();
            this.BtnOverschrijven = new System.Windows.Forms.Button();
            this.lblRekening = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbType
            // 
            this.lbType.FormattingEnabled = true;
            this.lbType.ItemHeight = 16;
            this.lbType.Location = new System.Drawing.Point(57, 68);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(152, 260);
            this.lbType.TabIndex = 0;
            this.lbType.SelectedIndexChanged += new System.EventHandler(this.lbType_SelectedIndexChanged);
            // 
            // lbRekening
            // 
            this.lbRekening.FormattingEnabled = true;
            this.lbRekening.ItemHeight = 16;
            this.lbRekening.Location = new System.Drawing.Point(235, 68);
            this.lbRekening.Name = "lbRekening";
            this.lbRekening.Size = new System.Drawing.Size(241, 260);
            this.lbRekening.TabIndex = 1;
            this.lbRekening.SelectedIndexChanged += new System.EventHandler(this.lbRekening_SelectedIndexChanged);
            // 
            // BtnOverschrijven
            // 
            this.BtnOverschrijven.Location = new System.Drawing.Point(499, 283);
            this.BtnOverschrijven.Name = "BtnOverschrijven";
            this.BtnOverschrijven.Size = new System.Drawing.Size(122, 45);
            this.BtnOverschrijven.TabIndex = 2;
            this.BtnOverschrijven.Text = "Overschrijven";
            this.BtnOverschrijven.UseVisualStyleBackColor = true;
            this.BtnOverschrijven.Click += new System.EventHandler(this.BtnOverschrijven_Click);
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Location = new System.Drawing.Point(235, 335);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(46, 17);
            this.lblRekening.TabIndex = 3;
            this.lblRekening.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 448);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRekening);
            this.Controls.Add(this.BtnOverschrijven);
            this.Controls.Add(this.lbRekening);
            this.Controls.Add(this.lbType);
            this.Name = "ViewAccounts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbType;
        private System.Windows.Forms.ListBox lbRekening;
        private System.Windows.Forms.Button BtnOverschrijven;
        private System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.Button btnDelete;
    }
}

