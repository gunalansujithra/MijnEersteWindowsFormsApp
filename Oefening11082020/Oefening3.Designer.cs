namespace Oefening11082020
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
            this.dtpMijnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpMijnDateTimePicker
            // 
            this.dtpMijnDateTimePicker.Location = new System.Drawing.Point(110, 88);
            this.dtpMijnDateTimePicker.Name = "dtpMijnDateTimePicker";
            this.dtpMijnDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dtpMijnDateTimePicker.TabIndex = 0;
            this.dtpMijnDateTimePicker.ValueChanged += new System.EventHandler(this.dtpMijnDateTimePicker_ValueChanged);
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpMijnDateTimePicker);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMijnDateTimePicker;
    }
}