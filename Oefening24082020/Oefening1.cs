using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening24082020
{
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        public List<Bedrijf> BedrijfLijst = new List<Bedrijf>();

        public List<Werknemer> werknemerLijst = new List<Werknemer>();
        private void Oefening1_Load(object sender, EventArgs e)
        {            
            Bedrijf bedrijf1 = new Bedrijf("Microsoft");
            Bedrijf bedrijf2 = new Bedrijf("Google");
            Bedrijf bedrijf3 = new Bedrijf("Apple");

            BedrijfLijst.Add(bedrijf1);
            BedrijfLijst.Add(bedrijf2);
            BedrijfLijst.Add(bedrijf3);
                        
            foreach (var item in BedrijfLijst)
            {
                cbBedrijAdd.Items.Add(item);
                cbBedrijf.Items.Add(item);
            }
            
            cbContract.Items.Add("Maandcontract");
            cbContract.Items.Add("Weekcontract");

            lbProgramTalen.Items.Add("HTML");
            lbProgramTalen.Items.Add("Java");
            lbProgramTalen.Items.Add("C#");
            lbProgramTalen.Items.Add("C++");


            Werknemer emp1 = new Salaris("Geert", contract: Salaris.ContractType.Weekcontract);
            Werknemer emp2 = new Salaris("Frank", salaris: 2200, contract: Salaris.ContractType.Maandcontract);
            Werknemer emp3 = new Salaris("Daniel", land: "Nederlands", contract: Salaris.ContractType.Weekcontract);
            Werknemer emp4 = new Salaris("Sofia", salaris: 3110, land: "Nederlands", contract: Salaris.ContractType.Maandcontract);

            BedrijfLijst[0].WerknemersLijst.Add(emp1);
            BedrijfLijst[0].WerknemersLijst.Add(emp2);
            BedrijfLijst[1].WerknemersLijst.Add(emp3);
            BedrijfLijst[2].WerknemersLijst.Add(emp4);

            cbBedrijf.SelectedIndex = -1;
            lblWerknemer.Visible = false;
            btnVerwijderen.Visible = false;
            lbProgramTalen.SelectedIndex = -1;
        }

        private void lbWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayWerknemerDetails();             
        }

        private void cbBedrijf_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayWerknemer();
        }

        private void btnVerwijdered_Click(object sender, EventArgs e)
        {
            if (lbWerknemer.SelectedItems.Count > 0)
            {
                BedrijfLijst[cbBedrijf.SelectedIndex].WerkenemerVerwijderen(lbWerknemer.SelectedIndex);
                MessageBox.Show("Werknemer verwijderd");
                DisplayWerknemer();
                DisplayWerknemerDetails();
            }
        }

        public void DisplayWerknemer()
        {
            if (cbBedrijf.SelectedIndex >= 0)
            {
                foreach (var item in BedrijfLijst)
                {
                    if (cbBedrijf.SelectedItem.ToString() == item.BedrijfNaam)
                    {
                        lbWerknemer.DataSource = null;
                        lbWerknemer.DataSource = item.WerknemersLijst;
                    }
                }
            }
        }
        public void DisplayWerknemerDetails()
        {
            if (lbWerknemer.DataSource != null && lbWerknemer.SelectedItems.Count > 0 && cbBedrijf.SelectedIndex >=0)
            {
                foreach (var item in BedrijfLijst[cbBedrijf.SelectedIndex].WerknemersLijst)
                {
                    if (item.Naam == lbWerknemer.SelectedItem.ToString())
                    {
                        lblWerknemer.Visible = true;
                        lblWerknemer.Text = item.Beschrijf();
                        btnVerwijderen.Visible = true;
                    }
                }
            }
            else
            {
                lblWerknemer.Visible = false;
                lblWerknemer.Text = "";
                btnVerwijderen.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbBedrijAdd.SelectedIndex >= 0 && txtNaam.Text.Trim().Length > 0)
            {
                int contractType = cbContract.SelectedIndex >= 0 ? cbContract.SelectedIndex : 0;
                string land = txtLand.Text.Trim().Length > 0 ? txtLand.Text.Trim() : "België";
                double salary = txtSalaris.Text.Trim().Length > 0 ? salary = Convert.ToDouble(txtSalaris.Text) : 2440.55;
                string talen = "";                
                bool isProgrammeur = false;

                if (lbProgramTalen.SelectedItems.Count > 0)
                {
                    isProgrammeur = true;
                    foreach (var item in lbProgramTalen.SelectedItems)
                    {
                        talen += item.ToString() + ", ";
                    }
                }

                if (isProgrammeur)
                {
                    BedrijfLijst[cbBedrijAdd.SelectedIndex].WerknermerToevoegen(txtNaam.Text, contractType, salary, land, talen, isProgrammeur);
                }
                else
                {
                    BedrijfLijst[cbBedrijAdd.SelectedIndex].WerknermerToevoegen(txtNaam.Text, contractType, salary, land, talen, isProgrammeur);
                }

                MessageBox.Show("Werknemer toegevoegt");
                txtNaam.Clear();
                txtSalaris.Clear();
                txtLand.Clear();
                cbContract.SelectedIndex = -1;
                cbBedrijAdd.SelectedIndex = -1;
                lbProgramTalen.SelectedIndex = -1;
            }
            else if (cbBedrijAdd.SelectedIndex < 0)
            {
                MessageBox.Show("Select bedrijf.");
            }
            else if (txtNaam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Werknemer naam is leeg.");
            }
                
        }

        private void txtSalaris_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
