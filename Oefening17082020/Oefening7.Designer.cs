namespace Oefening17082020
{
    partial class Oefening7
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbUur = new System.Windows.Forms.ComboBox();
            this.btnAfspraken = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.Label();
            this.cbDokter = new System.Windows.Forms.ComboBox();
            this.lbAfspraken = new System.Windows.Forms.ListBox();
            this.lblZieken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(383, 181);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 22);
            this.txtNaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "UUR";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(383, 222);
            this.dtpDatum.MinDate = new System.DateTime(2020, 8, 18, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 4;
            // 
            // cbUur
            // 
            this.cbUur.FormattingEnabled = true;
            this.cbUur.Location = new System.Drawing.Point(383, 266);
            this.cbUur.Name = "cbUur";
            this.cbUur.Size = new System.Drawing.Size(200, 24);
            this.cbUur.TabIndex = 5;
            // 
            // btnAfspraken
            // 
            this.btnAfspraken.Location = new System.Drawing.Point(383, 309);
            this.btnAfspraken.Name = "btnAfspraken";
            this.btnAfspraken.Size = new System.Drawing.Size(200, 42);
            this.btnAfspraken.TabIndex = 6;
            this.btnAfspraken.Text = "Afspraak Maken";
            this.btnAfspraken.UseVisualStyleBackColor = true;
            this.btnAfspraken.Click += new System.EventHandler(this.btnAfspraken_Click);
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(39, 100);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(79, 17);
            this.Do.TabIndex = 7;
            this.Do.Text = "Dokter Lijst";
            // 
            // cbDokter
            // 
            this.cbDokter.FormattingEnabled = true;
            this.cbDokter.Location = new System.Drawing.Point(42, 121);
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(203, 24);
            this.cbDokter.TabIndex = 8;
            this.cbDokter.SelectedIndexChanged += new System.EventHandler(this.cbDokter_SelectedIndexChanged);
            // 
            // lbAfspraken
            // 
            this.lbAfspraken.FormattingEnabled = true;
            this.lbAfspraken.ItemHeight = 16;
            this.lbAfspraken.Location = new System.Drawing.Point(42, 162);
            this.lbAfspraken.Name = "lbAfspraken";
            this.lbAfspraken.Size = new System.Drawing.Size(203, 212);
            this.lbAfspraken.TabIndex = 9;
            // 
            // lblZieken
            // 
            this.lblZieken.AutoSize = true;
            this.lblZieken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZieken.Location = new System.Drawing.Point(39, 37);
            this.lblZieken.Name = "lblZieken";
            this.lblZieken.Size = new System.Drawing.Size(117, 25);
            this.lblZieken.TabIndex = 10;
            this.lblZieken.Text = "Ziekenhuis";
            // 
            // Oefening7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 617);
            this.Controls.Add(this.lblZieken);
            this.Controls.Add(this.lbAfspraken);
            this.Controls.Add(this.cbDokter);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.btnAfspraken);
            this.Controls.Add(this.cbUur);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label1);
            this.Name = "Oefening7";
            this.Text = "Oefening7";
            this.Load += new System.EventHandler(this.Oefening7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbUur;
        private System.Windows.Forms.Button btnAfspraken;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.ComboBox cbDokter;
        private System.Windows.Forms.ListBox lbAfspraken;
        private System.Windows.Forms.Label lblZieken;
    }
}