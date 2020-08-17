namespace Oefening17082020
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
            this.btnBekijk = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBekijk
            // 
            this.btnBekijk.Location = new System.Drawing.Point(48, 21);
            this.btnBekijk.Name = "btnBekijk";
            this.btnBekijk.Size = new System.Drawing.Size(216, 44);
            this.btnBekijk.TabIndex = 0;
            this.btnBekijk.Text = "Bekijk Getal";
            this.btnBekijk.UseVisualStyleBackColor = true;
            this.btnBekijk.Click += new System.EventHandler(this.btnBekijk_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Location = new System.Drawing.Point(48, 87);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(216, 44);
            this.btnVerhoog.TabIndex = 1;
            this.btnVerhoog.Text = "Verhoog Getal";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Location = new System.Drawing.Point(48, 147);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(216, 44);
            this.btnVerlaag.TabIndex = 2;
            this.btnVerlaag.Text = "Verlaag Getal";
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.btnVerlaag_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(48, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(216, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Getal";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(48, 278);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(216, 44);
            this.btnAfsluiten.TabIndex = 4;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerlaag);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnBekijk);
            this.Name = "Oefening1";
            this.Text = "Oefening1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBekijk;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}