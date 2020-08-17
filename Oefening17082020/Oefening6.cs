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
    public partial class Oefening6 : Form
    {
        public Oefening6()
        {
            InitializeComponent();
        }

        private PretPark mijnPretpark = new PretPark();
        private void btnAddWerknemer_Click(object sender, EventArgs e)
        {

            string naam = "";
            if (txtNaam.Text.Trim().Length > 0)
            {
                naam = txtNaam.Text.Trim();
            }
            else
            {
                MessageBox.Show("Naam is leeg");
            }
            string geboorte = dtpDOB.Value.ToShortDateString();
            string geslacht = "";

            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    geslacht = item.Text;
                }
            }

            if (naam.Length > 0)
            {
                mijnPretpark.WerknemerToevoegen(naam, geboorte, geslacht);
                txtNaam.Clear();
                dtpDOB.Value = DateTime.Now;
                foreach (RadioButton item in groupBox1.Controls)
                {
                    item.Checked = false;
                }

                DisplayWerknemer();
            }
        }

        private void btnDeleteWerknemer_Click(object sender, EventArgs e)
        {
            if (lbWerknemer.SelectedItems.Count > 0)
            {
                mijnPretpark.WerknemerVerwijderen(lbWerknemer.SelectedIndex);

                DisplayWerknemer();
            }
        }

        private void lbWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWerknemer.SelectedItems.Count > 0)
            {
                lblWerknemerDetails.Text = mijnPretpark.WerknemerBekijken(lbWerknemer.SelectedIndex);
            }
        }

        public void DisplayWerknemer()
        {
            if (mijnPretpark.WerknemerLijst.Count > 0)
            {
                lbWerknemer.Items.Clear();
                foreach (var item in mijnPretpark.WerknemerLijst)
                {
                    lbWerknemer.Items.Add(item.Naam);
                }
            }
        }
    }
}
