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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private KlassRapport mijnKlassRapport = new KlassRapport();

        private void btnTaal_Click(object sender, EventArgs e)
        {
            if (txtTaal.Text.Trim().Length > 0)
            {
                int taalValue = Convert.ToInt32(txtTaal.Text.Trim());

                if (taalValue >= 0 && taalValue <= 100)
                {
                    mijnKlassRapport.AddTaalLijst(taalValue);
                    lbTaal.DataSource = null;
                    lbTaal.DataSource = mijnKlassRapport.TaalLijst;
                    txtTaal.Clear();
                    lblTaal.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeTaal();
                }
                else
                {
                    MessageBox.Show("Kies a getal tussen 0 en 100");
                }
            }
        }

        private void txtTaal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtRekenen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtICT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGeschiedenis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnRemoveTaal_Click(object sender, EventArgs e)
        {
            if (lbTaal.SelectedItems.Count > 0)
            {
                mijnKlassRapport.RemoveTaalLijst(lbTaal.SelectedIndex);
                lbTaal.DataSource = null;
                lbTaal.DataSource = mijnKlassRapport.TaalLijst;
                lblTaal.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeTaal();
            }
        }

        private void btnRekenen_Click(object sender, EventArgs e)
        {
            if (txtRekenen.Text.Trim().Length > 0)
            {
                int rekenenValue = Convert.ToInt32(txtRekenen.Text.Trim());

                if (rekenenValue >= 0 && rekenenValue <= 100)
                {
                    mijnKlassRapport.AddRekenenLijst(rekenenValue);
                    lbRekenen.DataSource = null;
                    lbRekenen.DataSource = mijnKlassRapport.RekenenLijst;
                    txtRekenen.Clear();
                    lblRekenen.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeRekenen();
                }
                else
                {
                    MessageBox.Show("Kies a getal tussen 0 en 100");
                }
            }
        }

        private void btnICT_Click(object sender, EventArgs e)
        {
            if (txtICT.Text.Trim().Length > 0)
            {
                int ictValue = Convert.ToInt32(txtICT.Text.Trim());

                if (ictValue >= 0 && ictValue <= 100)
                {
                    mijnKlassRapport.AddICTLijst(ictValue);
                    lbICT.DataSource = null;
                    lbICT.DataSource = mijnKlassRapport.ICTLijst;
                    txtICT.Clear();
                    lblICT.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeICT();
                }
                else
                {
                    MessageBox.Show("Kies a getal tussen 0 en 100");
                }
            }
        }

        private void btnGeschiedenis_Click(object sender, EventArgs e)
        {
            if (txtGeschiedenis.Text.Trim().Length > 0)
            {
                int geschValue = Convert.ToInt32(txtGeschiedenis.Text.Trim());

                if (geschValue >= 0 && geschValue <= 100)
                {
                    mijnKlassRapport.AddGeschiedenisLijst(geschValue);
                    lbGeschiedenis.DataSource = null;
                    lbGeschiedenis.DataSource = mijnKlassRapport.GeschiedenisLijst;
                    txtGeschiedenis.Clear();
                    lblGescheidenis.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeGescheidenis();
                }
                else
                {
                    MessageBox.Show("Kies a getal tussen 0 en 100");
                }
            }
        }

        private void btnRemoveRekenen_Click(object sender, EventArgs e)
        {
            if (lbRekenen.SelectedItems.Count > 0)
            {
                mijnKlassRapport.RemoveRekenenLijst(lbRekenen.SelectedIndex);
                lbRekenen.DataSource = null;
                lbRekenen.DataSource = mijnKlassRapport.RekenenLijst;
                lblRekenen.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeRekenen();
            }
        }

        private void btnRemoveICT_Click(object sender, EventArgs e)
        {
            if (lbICT.SelectedItems.Count > 0)
            {
                mijnKlassRapport.RemoveICTLijst(lbICT.SelectedIndex);
                lbICT.DataSource = null;
                lbICT.DataSource = mijnKlassRapport.ICTLijst;
                lblICT.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeICT();
            }
        }

        private void btnRemoveGeschiedenis_Click(object sender, EventArgs e)
        {
            if (lbGeschiedenis.SelectedItems.Count > 0)
            {
                mijnKlassRapport.RemoveGescheidenisLijst(lbGeschiedenis.SelectedIndex);
                lbGeschiedenis.DataSource = null;
                lbGeschiedenis.DataSource = mijnKlassRapport.GeschiedenisLijst;
                lblGescheidenis.Text = "Gemiddelde: " + mijnKlassRapport.GemiddeldeGescheidenis();
            }
        }
    }
}
