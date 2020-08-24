namespace Oefening24082020
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
            this.lbWerknemer = new System.Windows.Forms.ListBox();
            this.lblWerknemer = new System.Windows.Forms.Label();
            this.cbBedrijf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblBedrijf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalaris = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.cbBedrijAdd = new System.Windows.Forms.ComboBox();
            this.lbProgramTalen = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWerknemer
            // 
            this.lbWerknemer.FormattingEnabled = true;
            this.lbWerknemer.ItemHeight = 16;
            this.lbWerknemer.Location = new System.Drawing.Point(62, 469);
            this.lbWerknemer.Name = "lbWerknemer";
            this.lbWerknemer.Size = new System.Drawing.Size(246, 148);
            this.lbWerknemer.TabIndex = 1;
            this.lbWerknemer.SelectedIndexChanged += new System.EventHandler(this.lbWerknemer_SelectedIndexChanged);
            // 
            // lblWerknemer
            // 
            this.lblWerknemer.AutoSize = true;
            this.lblWerknemer.Location = new System.Drawing.Point(65, 636);
            this.lblWerknemer.Name = "lblWerknemer";
            this.lblWerknemer.Size = new System.Drawing.Size(46, 17);
            this.lblWerknemer.TabIndex = 2;
            this.lblWerknemer.Text = "label1";
            // 
            // cbBedrijf
            // 
            this.cbBedrijf.FormattingEnabled = true;
            this.cbBedrijf.Location = new System.Drawing.Point(62, 430);
            this.cbBedrijf.Name = "cbBedrijf";
            this.cbBedrijf.Size = new System.Drawing.Size(246, 24);
            this.cbBedrijf.TabIndex = 3;
            this.cbBedrijf.SelectedIndexChanged += new System.EventHandler(this.cbBedrijf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bedrijf Lijst";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(325, 571);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(139, 46);
            this.btnVerwijderen.TabIndex = 5;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijdered_Click);
            // 
            // lblBedrijf
            // 
            this.lblBedrijf.AutoSize = true;
            this.lblBedrijf.Location = new System.Drawing.Point(63, 18);
            this.lblBedrijf.Name = "lblBedrijf";
            this.lblBedrijf.Size = new System.Drawing.Size(48, 17);
            this.lblBedrijf.TabIndex = 7;
            this.lblBedrijf.Text = "Bedrijf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Werknemer Naam";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(218, 54);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(246, 22);
            this.txtNaam.TabIndex = 9;
            // 
            // cbContract
            // 
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(218, 91);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(246, 24);
            this.cbContract.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contract Type";
            // 
            // txtSalaris
            // 
            this.txtSalaris.Location = new System.Drawing.Point(218, 131);
            this.txtSalaris.Name = "txtSalaris";
            this.txtSalaris.Size = new System.Drawing.Size(246, 22);
            this.txtSalaris.TabIndex = 13;
            this.txtSalaris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaris_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Salaris";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(218, 168);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(246, 22);
            this.txtLand.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Land";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(218, 312);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(246, 44);
            this.btnToevoegen.TabIndex = 16;
            this.btnToevoegen.Text = "Werknemer Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBedrijAdd
            // 
            this.cbBedrijAdd.FormattingEnabled = true;
            this.cbBedrijAdd.Location = new System.Drawing.Point(218, 11);
            this.cbBedrijAdd.Name = "cbBedrijAdd";
            this.cbBedrijAdd.Size = new System.Drawing.Size(246, 24);
            this.cbBedrijAdd.TabIndex = 17;
            // 
            // lbProgramTalen
            // 
            this.lbProgramTalen.FormattingEnabled = true;
            this.lbProgramTalen.ItemHeight = 16;
            this.lbProgramTalen.Location = new System.Drawing.Point(218, 196);
            this.lbProgramTalen.Name = "lbProgramTalen";
            this.lbProgramTalen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProgramTalen.Size = new System.Drawing.Size(246, 100);
            this.lbProgramTalen.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Programmeurtalen";
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 720);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbProgramTalen);
            this.Controls.Add(this.cbBedrijAdd);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalaris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbContract);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBedrijf);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBedrijf);
            this.Controls.Add(this.lblWerknemer);
            this.Controls.Add(this.lbWerknemer);
            this.Name = "Oefening1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Oefening1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbWerknemer;
        private System.Windows.Forms.Label lblWerknemer;
        private System.Windows.Forms.ComboBox cbBedrijf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblBedrijf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalaris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ComboBox cbBedrijAdd;
        private System.Windows.Forms.ListBox lbProgramTalen;
        private System.Windows.Forms.Label label6;
    }
}

