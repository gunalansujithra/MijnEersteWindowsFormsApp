namespace Oefening19082020ClassInheritance
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
            this.lbMusic = new System.Windows.Forms.ListBox();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMusic
            // 
            this.lbMusic.FormattingEnabled = true;
            this.lbMusic.ItemHeight = 16;
            this.lbMusic.Location = new System.Drawing.Point(244, 106);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(446, 212);
            this.lbMusic.TabIndex = 1;
            this.lbMusic.SelectedIndexChanged += new System.EventHandler(this.lbMusic_SelectedIndexChanged);
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(244, 325);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(46, 17);
            this.lblMusic.TabIndex = 2;
            this.lblMusic.Text = "label1";
            // 
            // lbAlbum
            // 
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.ItemHeight = 16;
            this.lbAlbum.Location = new System.Drawing.Point(22, 106);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(186, 212);
            this.lbAlbum.TabIndex = 3;
            this.lbAlbum.SelectedIndexChanged += new System.EventHandler(this.lbAlbum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Music Album";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lbMusic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMusic;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.ListBox lbAlbum;
        private System.Windows.Forms.Label label1;
    }
}

