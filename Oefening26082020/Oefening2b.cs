using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening26082020
{
    public partial class Oefening2b : Form
    {
        public Oefening2b()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNederlands.Text.Trim().Length > 0 && txtEngels.Text.Trim().Length > 0
                && txtFrans.Text.Trim().Length > 0 && txtDuitse.Text.Trim().Length > 0
                && txtSpaans.Text.Trim().Length > 0 && txtItaliaans.Text.Trim().Length > 0)
            {
                Oefening2.Taal newTaal = new Oefening2.Taal(txtEngels.Text.Trim(),
                    txtFrans.Text.Trim(), txtDuitse.Text.Trim(),
                    txtSpaans.Text.Trim(), txtItaliaans.Text.Trim());

                Oefening2.number.Add(txtNederlands.Text.Trim(), newTaal);
                this.DialogResult = DialogResult.OK;
            }
            else if (txtNederlands.Text.Trim().Length <= 0 )
            {
                MessageBox.Show("Nederlands woord is leeg");
            }
            else if (txtEngels.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Engels woord is leeg");
            }
            else if (txtFrans.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Frans woord is leeg");
            }
            else if (txtDuitse.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Duitse woord is leeg");
            }
            else if (txtSpaans.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Spaans woord is leeg");
            }
            else if (txtItaliaans.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Italiaans woord is leeg");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
