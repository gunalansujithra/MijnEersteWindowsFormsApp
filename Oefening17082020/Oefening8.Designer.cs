namespace Oefening17082020
{
    partial class Oefening8
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
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.lblWerknemerDetails = new System.Windows.Forms.Label();
            this.btnKies = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(38, 283);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(200, 39);
            this.btnInschrijven.TabIndex = 25;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijven.Click += new System.EventHandler(this.btnInschrijven_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(38, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geslacht";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(88, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vrouw";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Man";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Leeftijd";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(117, 71);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 22);
            this.txtNaam.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Naam";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(117, 117);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.txtLeeftijd.TabIndex = 40;
            this.txtLeeftijd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeeftijd_KeyPress);
            // 
            // lblWerknemerDetails
            // 
            this.lblWerknemerDetails.AutoSize = true;
            this.lblWerknemerDetails.Location = new System.Drawing.Point(517, 104);
            this.lblWerknemerDetails.Name = "lblWerknemerDetails";
            this.lblWerknemerDetails.Size = new System.Drawing.Size(0, 17);
            this.lblWerknemerDetails.TabIndex = 44;
            // 
            // btnKies
            // 
            this.btnKies.Location = new System.Drawing.Point(298, 290);
            this.btnKies.Name = "btnKies";
            this.btnKies.Size = new System.Drawing.Size(200, 39);
            this.btnKies.TabIndex = 43;
            this.btnKies.Text = "Kies Studenten";
            this.btnKies.UseVisualStyleBackColor = true;
            this.btnKies.Click += new System.EventHandler(this.btnKies_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Student Lijst";
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.ItemHeight = 16;
            this.lbStudent.Location = new System.Drawing.Point(298, 88);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(194, 196);
            this.lbStudent.TabIndex = 41;
            // 
            // Oefening8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWerknemerDetails);
            this.Controls.Add(this.btnKies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.btnInschrijven);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label4);
            this.Name = "Oefening8";
            this.Text = "Oefening8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Label lblWerknemerDetails;
        private System.Windows.Forms.Button btnKies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStudent;
    }
}