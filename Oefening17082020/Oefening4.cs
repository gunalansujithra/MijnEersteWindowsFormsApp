using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening17082020
{
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        private Zwembad mijnZwembad = new Zwembad();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int lengte = 0;
            int breedte = 0;
            int diepte = 0;

            if (txtLengte.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lengte is leeg");
            }
            else
            {
                lengte = Convert.ToInt32(txtLengte.Text);
            }
            if (txtBreedte.Text.Trim().Length == 0)
            {
                MessageBox.Show("Breedte is leeg");
            }
            else
            {
                breedte = Convert.ToInt32(txtBreedte.Text);
            }
            if (txtDiepte.Text.Trim().Length == 0)
            {
                MessageBox.Show("Diepte is leeg");
            }
            else
            {
                diepte = Convert.ToInt32(txtDiepte.Text);
            }

            if (txtLengte.Text.Trim().Length > 0 && txtBreedte.Text.Trim().Length > 0 && txtDiepte.Text.Trim().Length > 0)
            {
                MessageBox.Show("De zwembad kan " + mijnZwembad.Calculate(lengte, breedte, diepte) + " liter water hier in kan");
            }
        }

        private void txtLengte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBreedte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiepte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
