using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening11082020
{
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }

        private void btnIndienen_Click(object sender, EventArgs e)
        {
            string geslacht = "";
            if (rbMan.Checked)
            {
                geslacht = rbMan.Text;
            }
            else if (rbVrouw.Checked)
            {
                geslacht = rbVrouw.Text;
            }

            string provincie = "";
            foreach (RadioButton rb in gbProvincie.Controls)
            {
                if(rb.Checked)
                {
                    provincie = rb.Text;
                }
            }

            string message = "Naam: " + txtNaam.Text.Trim()
                            + "\n" + "Adres: " + txtAdres.Text.Trim()
                            + "\n" + "Leeftijd: " + numericUpDown1.Text.Trim()
                            + "\n" + "Geslacht: " + geslacht
                            + "\n" + "Provincie: " + provincie;

            MessageBox.Show(message);
        }
    }
}
