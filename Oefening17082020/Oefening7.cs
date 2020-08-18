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
    public partial class Oefening7 : Form
    {
        public Oefening7()
        {
            InitializeComponent();
        }

        private Ziekenhuis mijnZiekenhuis = new Ziekenhuis();

        private void Oefening7_Load(object sender, EventArgs e)
        {
            cbDokter.DataSource = mijnZiekenhuis.DokterLijst;
            cbUur.DataSource = mijnZiekenhuis.ConsultationUurLijst;
            dtpDatum.MinDate = System.DateTime.Now.AddDays(1);

            mijnZiekenhuis.DrAfsprakenToevoegen("0");
            mijnZiekenhuis.DrAfsprakenToevoegen("1");
            mijnZiekenhuis.DrAfsprakenToevoegen("2");
            mijnZiekenhuis.DrAfsprakenToevoegen("3");
            mijnZiekenhuis.DrAfsprakenToevoegen("4");
            
        }

        private void btnAfspraken_Click(object sender, EventArgs e)
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
            string datum = dtpDatum.Value.ToShortDateString();
            string tijd = cbUur.Text;

            if (naam.Length > 0)
            {
                mijnZiekenhuis.DokterAfsprakenLijst[cbDokter.SelectedIndex].AppointmentToevoegen(naam, datum, tijd);
                //mijnZiekenhuis.AppointmentLijst[cbDokter.SelectedIndex]..AddStudent(naam, geboorte, geslacht);
                txtNaam.Clear();
                dtpDatum.Value = DateTime.Now;
                cbUur.SelectedIndex = 0;

                if (mijnZiekenhuis.DokterAfsprakenLijst[cbDokter.SelectedIndex].AppointmentLijst.Count > 0)
                {
                    lbAfspraken.Items.Clear();
                    foreach (var item in mijnZiekenhuis.DokterAfsprakenLijst[cbDokter.SelectedIndex].AppointmentLijst)
                    {
                        string afsprak = item.Naam + " (" + item.Date + ") - " + item.Time;
                        lbAfspraken.Items.Add(afsprak);
                    }
                }
            }
            else
            {
                MessageBox.Show("Naam is leeg");
            }

        }

        private void cbDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mijnZiekenhuis.DokterAfsprakenLijst.Count > 0)
            {
                if (mijnZiekenhuis.DokterAfsprakenLijst[cbDokter.SelectedIndex].AppointmentLijst.Count > 0)
                {
                    lbAfspraken.Items.Clear();
                    foreach (var item in mijnZiekenhuis.DokterAfsprakenLijst[cbDokter.SelectedIndex].AppointmentLijst)
                    {
                        string afsprak = item.Naam + " (" + item.Date + ") - " + item.Time;
                        lbAfspraken.Items.Add(afsprak);
                    }
                }
                else
                {
                    lbAfspraken.Items.Clear();
                }
            }
        }
    }
}
