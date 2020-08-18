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
                lblWerknemerDetails.Text = "";
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
            else
            {
                lbWerknemer.Items.Clear();
            }
        }

        private void txtAantalPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtLeeftijd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDeleteAttractie_Click(object sender, EventArgs e)
        {
            if (lbAttractie.SelectedItems.Count > 0)
            {
                mijnPretpark.AttractieVerwijderen(lbAttractie.SelectedIndex);

                DisplayAttractie();
                lblAttractieDetails.Text = "";
            }
        }

        private void btnAddAttractie_Click(object sender, EventArgs e)
        {
            string naam = "";
            string kleur = "";
            int leeftijd = -1;
            int aantalperson = -1;
            if (txtAttaractieNaam.Text.Trim().Length > 0)
            {
                naam = txtAttaractieNaam.Text.Trim();
            }
            else
            {
                MessageBox.Show("Attratie naam is leeg");
            }

            if (txtKleur.Text.Trim().Length > 0)
            {
                kleur = txtKleur.Text.Trim();
            }
            else
            {
                MessageBox.Show("Kleur is leeg");
            }

            if (txtLeeftijd.Text.Trim().Length > 0)
            {
                leeftijd = Convert.ToInt32(txtLeeftijd.Text.Trim());
            }
            else
            {
                MessageBox.Show("Leeftijd is leeg");
            }

            if (txtAantalPerson.Text.Trim().Length > 0)
            {
                aantalperson = Convert.ToInt32(txtAantalPerson.Text.Trim());
            }
            else
            {
                MessageBox.Show("Maximum aantal personen is leeg");
            }


            if (naam.Length > 0 && kleur.Length > 0 && leeftijd >= 0 && aantalperson >= 0)
            {
                mijnPretpark.AttractieToevoegen(naam, kleur, leeftijd, aantalperson);
                txtAttaractieNaam.Clear();
                txtKleur.Clear();
                txtLeeftijd.Clear();
                txtAantalPerson.Clear();
                
                DisplayAttractie();
            }
        }

        public void DisplayAttractie()
        {
            if (mijnPretpark.AttratieLijst.Count > 0)
            {
                lbAttractie.Items.Clear();
                foreach (var item in mijnPretpark.AttratieLijst)
                {
                    lbAttractie.Items.Add(item.Naam);
                }
            }
            else
            {
                lbAttractie.Items.Clear();
            }
        }

        private void lbAttractie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAttractie.SelectedItems.Count > 0)
            {
                lblAttractieDetails.Text = mijnPretpark.AttractieBekijken(lbAttractie.SelectedIndex);
            }
        }

    }
}
