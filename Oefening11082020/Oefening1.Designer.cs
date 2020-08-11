namespace Oefening11082020
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbActive = new System.Windows.Forms.ListBox();
            this.lbInactive = new System.Windows.Forms.ListBox();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(53, 32);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(193, 22);
            this.txtNaam.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(263, 27);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(172, 33);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbActive
            // 
            this.lbActive.FormattingEnabled = true;
            this.lbActive.ItemHeight = 16;
            this.lbActive.Location = new System.Drawing.Point(53, 72);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(193, 308);
            this.lbActive.TabIndex = 2;
            // 
            // lbInactive
            // 
            this.lbInactive.FormattingEnabled = true;
            this.lbInactive.ItemHeight = 16;
            this.lbInactive.Location = new System.Drawing.Point(384, 72);
            this.lbInactive.Name = "lbInactive";
            this.lbInactive.Size = new System.Drawing.Size(204, 308);
            this.lbInactive.TabIndex = 3;
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(279, 165);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(75, 30);
            this.btnRechts.TabIndex = 4;
            this.btnRechts.Text = "=>";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(279, 210);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(75, 29);
            this.btnLinks.TabIndex = 5;
            this.btnLinks.Text = "<=";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.lbInactive);
            this.Controls.Add(this.lbActive);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtNaam);
            this.Name = "Oefening1";
            this.Text = "Oefening1";
            this.Load += new System.EventHandler(this.Oefening1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lbActive;
        private System.Windows.Forms.ListBox lbInactive;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnLinks;
    }
}