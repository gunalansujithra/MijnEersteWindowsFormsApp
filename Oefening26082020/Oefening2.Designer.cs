namespace Oefening26082020
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
            this.lblEngels = new System.Windows.Forms.Label();
            this.cbNummers = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFrans = new System.Windows.Forms.Label();
            this.lblDuitse = new System.Windows.Forms.Label();
            this.lblSpaans = new System.Windows.Forms.Label();
            this.lblItaliaans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEngels
            // 
            this.lblEngels.AutoSize = true;
            this.lblEngels.Location = new System.Drawing.Point(64, 95);
            this.lblEngels.Name = "lblEngels";
            this.lblEngels.Size = new System.Drawing.Size(51, 17);
            this.lblEngels.TabIndex = 3;
            this.lblEngels.Text = "Engels";
            // 
            // cbNummers
            // 
            this.cbNummers.FormattingEnabled = true;
            this.cbNummers.Location = new System.Drawing.Point(64, 44);
            this.cbNummers.Name = "cbNummers";
            this.cbNummers.Size = new System.Drawing.Size(183, 24);
            this.cbNummers.TabIndex = 2;
            this.cbNummers.SelectedIndexChanged += new System.EventHandler(this.cbNummers_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(391, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFrans
            // 
            this.lblFrans.AutoSize = true;
            this.lblFrans.Location = new System.Drawing.Point(64, 125);
            this.lblFrans.Name = "lblFrans";
            this.lblFrans.Size = new System.Drawing.Size(44, 17);
            this.lblFrans.TabIndex = 6;
            this.lblFrans.Text = "Frans";
            // 
            // lblDuitse
            // 
            this.lblDuitse.AutoSize = true;
            this.lblDuitse.Location = new System.Drawing.Point(64, 157);
            this.lblDuitse.Name = "lblDuitse";
            this.lblDuitse.Size = new System.Drawing.Size(48, 17);
            this.lblDuitse.TabIndex = 7;
            this.lblDuitse.Text = "Duitse";
            // 
            // lblSpaans
            // 
            this.lblSpaans.AutoSize = true;
            this.lblSpaans.Location = new System.Drawing.Point(64, 195);
            this.lblSpaans.Name = "lblSpaans";
            this.lblSpaans.Size = new System.Drawing.Size(56, 17);
            this.lblSpaans.TabIndex = 8;
            this.lblSpaans.Text = "Spaans";
            // 
            // lblItaliaans
            // 
            this.lblItaliaans.AutoSize = true;
            this.lblItaliaans.Location = new System.Drawing.Point(64, 225);
            this.lblItaliaans.Name = "lblItaliaans";
            this.lblItaliaans.Size = new System.Drawing.Size(60, 17);
            this.lblItaliaans.TabIndex = 9;
            this.lblItaliaans.Text = "Italiaans";
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblItaliaans);
            this.Controls.Add(this.lblSpaans);
            this.Controls.Add(this.lblDuitse);
            this.Controls.Add(this.lblFrans);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEngels);
            this.Controls.Add(this.cbNummers);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEngels;
        private System.Windows.Forms.ComboBox cbNummers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFrans;
        private System.Windows.Forms.Label lblDuitse;
        private System.Windows.Forms.Label lblSpaans;
        private System.Windows.Forms.Label lblItaliaans;
    }
}