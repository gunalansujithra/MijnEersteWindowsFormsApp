namespace Oefening11082020
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
            this.lblNotitieBoekjes = new System.Windows.Forms.Label();
            this.lbNotities = new System.Windows.Forms.ListBox();
            this.btnVoegNotitie = new System.Windows.Forms.Button();
            this.btnScheurNotitie = new System.Windows.Forms.Button();
            this.lblNotitieboekje = new System.Windows.Forms.Label();
            this.lblNotitie = new System.Windows.Forms.Label();
            this.txtNotite = new System.Windows.Forms.TextBox();
            this.lblBijschrijven = new System.Windows.Forms.Label();
            this.txtBijschrijven = new System.Windows.Forms.TextBox();
            this.btnBijschrijven = new System.Windows.Forms.Button();
            this.btnLamineren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotitieBoekjes
            // 
            this.lblNotitieBoekjes.Location = new System.Drawing.Point(0, 0);
            this.lblNotitieBoekjes.Name = "lblNotitieBoekjes";
            this.lblNotitieBoekjes.Size = new System.Drawing.Size(100, 23);
            this.lblNotitieBoekjes.TabIndex = 4;
            // 
            // lbNotities
            // 
            this.lbNotities.FormattingEnabled = true;
            this.lbNotities.ItemHeight = 16;
            this.lbNotities.Location = new System.Drawing.Point(44, 42);
            this.lbNotities.Name = "lbNotities";
            this.lbNotities.Size = new System.Drawing.Size(204, 292);
            this.lbNotities.TabIndex = 1;
            this.lbNotities.SelectedIndexChanged += new System.EventHandler(this.lbNotities_SelectedIndexChanged);
            // 
            // btnVoegNotitie
            // 
            this.btnVoegNotitie.Location = new System.Drawing.Point(44, 341);
            this.btnVoegNotitie.Name = "btnVoegNotitie";
            this.btnVoegNotitie.Size = new System.Drawing.Size(204, 41);
            this.btnVoegNotitie.TabIndex = 2;
            this.btnVoegNotitie.Text = "Voeg notitie toe";
            this.btnVoegNotitie.UseVisualStyleBackColor = true;
            this.btnVoegNotitie.Click += new System.EventHandler(this.btnVoegNotitie_Click);
            // 
            // btnScheurNotitie
            // 
            this.btnScheurNotitie.Location = new System.Drawing.Point(44, 388);
            this.btnScheurNotitie.Name = "btnScheurNotitie";
            this.btnScheurNotitie.Size = new System.Drawing.Size(204, 41);
            this.btnScheurNotitie.TabIndex = 3;
            this.btnScheurNotitie.Text = "Scheur notitie uit";
            this.btnScheurNotitie.UseVisualStyleBackColor = true;
            this.btnScheurNotitie.Click += new System.EventHandler(this.btnScheurNotitie_Click);
            // 
            // lblNotitieboekje
            // 
            this.lblNotitieboekje.AutoSize = true;
            this.lblNotitieboekje.Location = new System.Drawing.Point(41, 16);
            this.lblNotitieboekje.Name = "lblNotitieboekje";
            this.lblNotitieboekje.Size = new System.Drawing.Size(90, 17);
            this.lblNotitieboekje.TabIndex = 5;
            this.lblNotitieboekje.Text = "Notitieboekje";
            // 
            // lblNotitie
            // 
            this.lblNotitie.AutoSize = true;
            this.lblNotitie.Location = new System.Drawing.Point(269, 16);
            this.lblNotitie.Name = "lblNotitie";
            this.lblNotitie.Size = new System.Drawing.Size(48, 17);
            this.lblNotitie.TabIndex = 6;
            this.lblNotitie.Text = "Notitie";
            // 
            // txtNotite
            // 
            this.txtNotite.Enabled = false;
            this.txtNotite.Location = new System.Drawing.Point(255, 42);
            this.txtNotite.Multiline = true;
            this.txtNotite.Name = "txtNotite";
            this.txtNotite.Size = new System.Drawing.Size(378, 292);
            this.txtNotite.TabIndex = 7;
            // 
            // lblBijschrijven
            // 
            this.lblBijschrijven.AutoSize = true;
            this.lblBijschrijven.Location = new System.Drawing.Point(255, 341);
            this.lblBijschrijven.Name = "lblBijschrijven";
            this.lblBijschrijven.Size = new System.Drawing.Size(79, 17);
            this.lblBijschrijven.TabIndex = 8;
            this.lblBijschrijven.Text = "Bijschrijven";
            // 
            // txtBijschrijven
            // 
            this.txtBijschrijven.Location = new System.Drawing.Point(258, 362);
            this.txtBijschrijven.Name = "txtBijschrijven";
            this.txtBijschrijven.Size = new System.Drawing.Size(320, 22);
            this.txtBijschrijven.TabIndex = 9;
            // 
            // btnBijschrijven
            // 
            this.btnBijschrijven.Location = new System.Drawing.Point(582, 359);
            this.btnBijschrijven.Name = "btnBijschrijven";
            this.btnBijschrijven.Size = new System.Drawing.Size(51, 27);
            this.btnBijschrijven.TabIndex = 10;
            this.btnBijschrijven.Text = "->";
            this.btnBijschrijven.UseVisualStyleBackColor = true;
            this.btnBijschrijven.Click += new System.EventHandler(this.btnBijschrijven_Click);
            // 
            // btnLamineren
            // 
            this.btnLamineren.Location = new System.Drawing.Point(410, 392);
            this.btnLamineren.Name = "btnLamineren";
            this.btnLamineren.Size = new System.Drawing.Size(223, 38);
            this.btnLamineren.TabIndex = 11;
            this.btnLamineren.Text = "Lamineren";
            this.btnLamineren.UseVisualStyleBackColor = true;
            this.btnLamineren.Click += new System.EventHandler(this.btnLamineren_Click);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamineren);
            this.Controls.Add(this.btnBijschrijven);
            this.Controls.Add(this.txtBijschrijven);
            this.Controls.Add(this.lblBijschrijven);
            this.Controls.Add(this.txtNotite);
            this.Controls.Add(this.lblNotitie);
            this.Controls.Add(this.lblNotitieboekje);
            this.Controls.Add(this.btnScheurNotitie);
            this.Controls.Add(this.btnVoegNotitie);
            this.Controls.Add(this.lbNotities);
            this.Controls.Add(this.lblNotitieBoekjes);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            this.Load += new System.EventHandler(this.Oefening4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotitieBoekjes;
        private System.Windows.Forms.ListBox lbNotities;
        private System.Windows.Forms.Button btnVoegNotitie;
        private System.Windows.Forms.Button btnScheurNotitie;
        private System.Windows.Forms.Label lblNotitieboekje;
        private System.Windows.Forms.Label lblNotitie;
        private System.Windows.Forms.TextBox txtNotite;
        private System.Windows.Forms.Label lblBijschrijven;
        private System.Windows.Forms.TextBox txtBijschrijven;
        private System.Windows.Forms.Button btnBijschrijven;
        private System.Windows.Forms.Button btnLamineren;
    }
}