namespace Oefening17082020
{
    partial class Oefening3
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
            this.txtTaal = new System.Windows.Forms.TextBox();
            this.btnTaal = new System.Windows.Forms.Button();
            this.lbTaal = new System.Windows.Forms.ListBox();
            this.btnRemoveTaal = new System.Windows.Forms.Button();
            this.lblTaal = new System.Windows.Forms.Label();
            this.lblRekenen = new System.Windows.Forms.Label();
            this.btnRemoveRekenen = new System.Windows.Forms.Button();
            this.lbRekenen = new System.Windows.Forms.ListBox();
            this.btnRekenen = new System.Windows.Forms.Button();
            this.txtRekenen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblICT = new System.Windows.Forms.Label();
            this.btnRemoveICT = new System.Windows.Forms.Button();
            this.lbICT = new System.Windows.Forms.ListBox();
            this.btnICT = new System.Windows.Forms.Button();
            this.txtICT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGescheidenis = new System.Windows.Forms.Label();
            this.btnRemoveGeschiedenis = new System.Windows.Forms.Button();
            this.lbGeschiedenis = new System.Windows.Forms.ListBox();
            this.btnGeschiedenis = new System.Windows.Forms.Button();
            this.txtGeschiedenis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taal";
            // 
            // txtTaal
            // 
            this.txtTaal.Location = new System.Drawing.Point(30, 51);
            this.txtTaal.MaxLength = 3;
            this.txtTaal.Name = "txtTaal";
            this.txtTaal.Size = new System.Drawing.Size(50, 22);
            this.txtTaal.TabIndex = 1;
            this.txtTaal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaal_KeyPress);
            // 
            // btnTaal
            // 
            this.btnTaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaal.Location = new System.Drawing.Point(87, 49);
            this.btnTaal.Name = "btnTaal";
            this.btnTaal.Size = new System.Drawing.Size(63, 24);
            this.btnTaal.TabIndex = 2;
            this.btnTaal.Text = "Add";
            this.btnTaal.UseVisualStyleBackColor = true;
            this.btnTaal.Click += new System.EventHandler(this.btnTaal_Click);
            // 
            // lbTaal
            // 
            this.lbTaal.FormattingEnabled = true;
            this.lbTaal.ItemHeight = 16;
            this.lbTaal.Location = new System.Drawing.Point(30, 80);
            this.lbTaal.Name = "lbTaal";
            this.lbTaal.Size = new System.Drawing.Size(120, 228);
            this.lbTaal.TabIndex = 3;
            // 
            // btnRemoveTaal
            // 
            this.btnRemoveTaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTaal.Location = new System.Drawing.Point(30, 315);
            this.btnRemoveTaal.Name = "btnRemoveTaal";
            this.btnRemoveTaal.Size = new System.Drawing.Size(120, 32);
            this.btnRemoveTaal.TabIndex = 4;
            this.btnRemoveTaal.Text = "Remove";
            this.btnRemoveTaal.UseVisualStyleBackColor = true;
            this.btnRemoveTaal.Click += new System.EventHandler(this.btnRemoveTaal_Click);
            // 
            // lblTaal
            // 
            this.lblTaal.AutoSize = true;
            this.lblTaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaal.Location = new System.Drawing.Point(30, 363);
            this.lblTaal.Name = "lblTaal";
            this.lblTaal.Size = new System.Drawing.Size(104, 17);
            this.lblTaal.TabIndex = 5;
            this.lblTaal.Text = "Gemiddelde: ";
            // 
            // lblRekenen
            // 
            this.lblRekenen.AutoSize = true;
            this.lblRekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekenen.Location = new System.Drawing.Point(167, 363);
            this.lblRekenen.Name = "lblRekenen";
            this.lblRekenen.Size = new System.Drawing.Size(104, 17);
            this.lblRekenen.TabIndex = 11;
            this.lblRekenen.Text = "Gemiddelde: ";
            // 
            // btnRemoveRekenen
            // 
            this.btnRemoveRekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRekenen.Location = new System.Drawing.Point(167, 315);
            this.btnRemoveRekenen.Name = "btnRemoveRekenen";
            this.btnRemoveRekenen.Size = new System.Drawing.Size(120, 32);
            this.btnRemoveRekenen.TabIndex = 10;
            this.btnRemoveRekenen.Text = "Remove";
            this.btnRemoveRekenen.UseVisualStyleBackColor = true;
            this.btnRemoveRekenen.Click += new System.EventHandler(this.btnRemoveRekenen_Click);
            // 
            // lbRekenen
            // 
            this.lbRekenen.FormattingEnabled = true;
            this.lbRekenen.ItemHeight = 16;
            this.lbRekenen.Location = new System.Drawing.Point(167, 80);
            this.lbRekenen.Name = "lbRekenen";
            this.lbRekenen.Size = new System.Drawing.Size(120, 228);
            this.lbRekenen.TabIndex = 9;
            // 
            // btnRekenen
            // 
            this.btnRekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekenen.Location = new System.Drawing.Point(224, 49);
            this.btnRekenen.Name = "btnRekenen";
            this.btnRekenen.Size = new System.Drawing.Size(63, 24);
            this.btnRekenen.TabIndex = 8;
            this.btnRekenen.Text = "Add";
            this.btnRekenen.UseVisualStyleBackColor = true;
            this.btnRekenen.Click += new System.EventHandler(this.btnRekenen_Click);
            // 
            // txtRekenen
            // 
            this.txtRekenen.Location = new System.Drawing.Point(167, 51);
            this.txtRekenen.MaxLength = 3;
            this.txtRekenen.Name = "txtRekenen";
            this.txtRekenen.Size = new System.Drawing.Size(50, 22);
            this.txtRekenen.TabIndex = 7;
            this.txtRekenen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRekenen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rekenen";
            // 
            // lblICT
            // 
            this.lblICT.AutoSize = true;
            this.lblICT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICT.Location = new System.Drawing.Point(305, 363);
            this.lblICT.Name = "lblICT";
            this.lblICT.Size = new System.Drawing.Size(104, 17);
            this.lblICT.TabIndex = 17;
            this.lblICT.Text = "Gemiddelde: ";
            // 
            // btnRemoveICT
            // 
            this.btnRemoveICT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveICT.Location = new System.Drawing.Point(305, 315);
            this.btnRemoveICT.Name = "btnRemoveICT";
            this.btnRemoveICT.Size = new System.Drawing.Size(120, 32);
            this.btnRemoveICT.TabIndex = 16;
            this.btnRemoveICT.Text = "Remove";
            this.btnRemoveICT.UseVisualStyleBackColor = true;
            this.btnRemoveICT.Click += new System.EventHandler(this.btnRemoveICT_Click);
            // 
            // lbICT
            // 
            this.lbICT.FormattingEnabled = true;
            this.lbICT.ItemHeight = 16;
            this.lbICT.Location = new System.Drawing.Point(305, 80);
            this.lbICT.Name = "lbICT";
            this.lbICT.Size = new System.Drawing.Size(120, 228);
            this.lbICT.TabIndex = 15;
            // 
            // btnICT
            // 
            this.btnICT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnICT.Location = new System.Drawing.Point(362, 49);
            this.btnICT.Name = "btnICT";
            this.btnICT.Size = new System.Drawing.Size(63, 24);
            this.btnICT.TabIndex = 14;
            this.btnICT.Text = "Add";
            this.btnICT.UseVisualStyleBackColor = true;
            this.btnICT.Click += new System.EventHandler(this.btnICT_Click);
            // 
            // txtICT
            // 
            this.txtICT.Location = new System.Drawing.Point(305, 51);
            this.txtICT.MaxLength = 3;
            this.txtICT.Name = "txtICT";
            this.txtICT.Size = new System.Drawing.Size(50, 22);
            this.txtICT.TabIndex = 13;
            this.txtICT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtICT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "ICT";
            // 
            // lblGescheidenis
            // 
            this.lblGescheidenis.AutoSize = true;
            this.lblGescheidenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGescheidenis.Location = new System.Drawing.Point(449, 363);
            this.lblGescheidenis.Name = "lblGescheidenis";
            this.lblGescheidenis.Size = new System.Drawing.Size(104, 17);
            this.lblGescheidenis.TabIndex = 23;
            this.lblGescheidenis.Text = "Gemiddelde: ";
            // 
            // btnRemoveGeschiedenis
            // 
            this.btnRemoveGeschiedenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGeschiedenis.Location = new System.Drawing.Point(449, 315);
            this.btnRemoveGeschiedenis.Name = "btnRemoveGeschiedenis";
            this.btnRemoveGeschiedenis.Size = new System.Drawing.Size(120, 32);
            this.btnRemoveGeschiedenis.TabIndex = 22;
            this.btnRemoveGeschiedenis.Text = "Remove";
            this.btnRemoveGeschiedenis.UseVisualStyleBackColor = true;
            this.btnRemoveGeschiedenis.Click += new System.EventHandler(this.btnRemoveGeschiedenis_Click);
            // 
            // lbGeschiedenis
            // 
            this.lbGeschiedenis.FormattingEnabled = true;
            this.lbGeschiedenis.ItemHeight = 16;
            this.lbGeschiedenis.Location = new System.Drawing.Point(449, 80);
            this.lbGeschiedenis.Name = "lbGeschiedenis";
            this.lbGeschiedenis.Size = new System.Drawing.Size(120, 228);
            this.lbGeschiedenis.TabIndex = 21;
            // 
            // btnGeschiedenis
            // 
            this.btnGeschiedenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeschiedenis.Location = new System.Drawing.Point(506, 49);
            this.btnGeschiedenis.Name = "btnGeschiedenis";
            this.btnGeschiedenis.Size = new System.Drawing.Size(63, 24);
            this.btnGeschiedenis.TabIndex = 20;
            this.btnGeschiedenis.Text = "Add";
            this.btnGeschiedenis.UseVisualStyleBackColor = true;
            this.btnGeschiedenis.Click += new System.EventHandler(this.btnGeschiedenis_Click);
            // 
            // txtGeschiedenis
            // 
            this.txtGeschiedenis.Location = new System.Drawing.Point(449, 51);
            this.txtGeschiedenis.MaxLength = 3;
            this.txtGeschiedenis.Name = "txtGeschiedenis";
            this.txtGeschiedenis.Size = new System.Drawing.Size(50, 22);
            this.txtGeschiedenis.TabIndex = 19;
            this.txtGeschiedenis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeschiedenis_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Geschiedenis";
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 553);
            this.Controls.Add(this.lblGescheidenis);
            this.Controls.Add(this.btnRemoveGeschiedenis);
            this.Controls.Add(this.lbGeschiedenis);
            this.Controls.Add(this.btnGeschiedenis);
            this.Controls.Add(this.txtGeschiedenis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblICT);
            this.Controls.Add(this.btnRemoveICT);
            this.Controls.Add(this.lbICT);
            this.Controls.Add(this.btnICT);
            this.Controls.Add(this.txtICT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRekenen);
            this.Controls.Add(this.btnRemoveRekenen);
            this.Controls.Add(this.lbRekenen);
            this.Controls.Add(this.btnRekenen);
            this.Controls.Add(this.txtRekenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTaal);
            this.Controls.Add(this.btnRemoveTaal);
            this.Controls.Add(this.lbTaal);
            this.Controls.Add(this.btnTaal);
            this.Controls.Add(this.txtTaal);
            this.Controls.Add(this.label1);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaal;
        private System.Windows.Forms.Button btnTaal;
        private System.Windows.Forms.ListBox lbTaal;
        private System.Windows.Forms.Button btnRemoveTaal;
        private System.Windows.Forms.Label lblTaal;
        private System.Windows.Forms.Label lblRekenen;
        private System.Windows.Forms.Button btnRemoveRekenen;
        private System.Windows.Forms.ListBox lbRekenen;
        private System.Windows.Forms.Button btnRekenen;
        private System.Windows.Forms.TextBox txtRekenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblICT;
        private System.Windows.Forms.Button btnRemoveICT;
        private System.Windows.Forms.ListBox lbICT;
        private System.Windows.Forms.Button btnICT;
        private System.Windows.Forms.TextBox txtICT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGescheidenis;
        private System.Windows.Forms.Button btnRemoveGeschiedenis;
        private System.Windows.Forms.ListBox lbGeschiedenis;
        private System.Windows.Forms.Button btnGeschiedenis;
        private System.Windows.Forms.TextBox txtGeschiedenis;
        private System.Windows.Forms.Label label7;
    }
}