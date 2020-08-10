namespace MijnEersteWindowsFormsApp
{
    partial class oefening1
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNaam
            // 
            this.lbNaam.FormattingEnabled = true;
            this.lbNaam.ItemHeight = 16;
            this.lbNaam.Location = new System.Drawing.Point(71, 28);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(348, 196);
            this.lbNaam.TabIndex = 0;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(80, 298);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(339, 22);
            this.txtNaam.TabIndex = 1;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(472, 296);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(204, 48);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lbNaam);
            this.Name = "oefening1";
            this.Text = "oefening1";
            this.Load += new System.EventHandler(this.oefening1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnToevoegen;
    }
}