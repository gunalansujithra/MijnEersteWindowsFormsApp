namespace Oefening21082020Bankapp
{
    partial class AddAccount
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
            this.txtRekeningNummer = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRekeningType = new System.Windows.Forms.ComboBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.lblCvv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekening nummer";
            // 
            // txtRekeningNummer
            // 
            this.txtRekeningNummer.Location = new System.Drawing.Point(256, 45);
            this.txtRekeningNummer.MaxLength = 17;
            this.txtRekeningNummer.Name = "txtRekeningNummer";
            this.txtRekeningNummer.Size = new System.Drawing.Size(197, 22);
            this.txtRekeningNummer.TabIndex = 1;
            this.txtRekeningNummer.TextChanged += new System.EventHandler(this.txtRekeningNummer_TextChanged);
            this.txtRekeningNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRekeningNummer_KeyPress);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(223, 99);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(230, 22);
            this.txtNaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(223, 231);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(204, 49);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rekening Type";
            // 
            // cbRekeningType
            // 
            this.cbRekeningType.FormattingEnabled = true;
            this.cbRekeningType.Location = new System.Drawing.Point(223, 145);
            this.cbRekeningType.Name = "cbRekeningType";
            this.cbRekeningType.Size = new System.Drawing.Size(230, 24);
            this.cbRekeningType.TabIndex = 6;
            this.cbRekeningType.SelectedIndexChanged += new System.EventHandler(this.cbRekeningType_SelectedIndexChanged);
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(223, 185);
            this.txtCvv.MaxLength = 3;
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(230, 22);
            this.txtCvv.TabIndex = 8;
            this.txtCvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvv_KeyPress);
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Location = new System.Drawing.Point(76, 185);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(35, 17);
            this.lblCvv.TabIndex = 7;
            this.lblCvv.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "BE";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.cbRekeningType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRekeningNummer);
            this.Controls.Add(this.label1);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRekeningNummer;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRekeningType;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.Label label4;
    }
}