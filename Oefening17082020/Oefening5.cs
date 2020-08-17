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
    public partial class Oefening5 : Form
    {
        public Oefening5()
        {
            InitializeComponent();
        }

        private School mijnSchool = new School();

        private void btnAddKlas_Click(object sender, EventArgs e)
        {
            string jaar = "";
            bool isKlas = true;
            if (txtJaar.Text.Trim().Length > 0)
            {
                jaar = txtJaar.Text.Trim();                
            }
            else
            {
                MessageBox.Show("Jaar is leeg");
                isKlas = false;
            }

            string richting = "";
            if(txtRichting.Text.Trim().Length > 0)
            {
                richting = txtRichting.Text.Trim();
            }
            else
            {
                MessageBox.Show("Richting is leeg");
                isKlas = false;
            }

            if (isKlas)
            {
                mijnSchool.AddKlas(jaar, richting);
                txtJaar.Clear();
                txtRichting.Clear();

                if (mijnSchool.KlasLijst.Count > 0)
                {
                    lbKlas.Items.Clear();   
                    foreach(var item in mijnSchool.KlasLijst)
                    {
                        string klassNaam = item.Jaar + " - " + item.Richting;
                        lbKlas.Items.Add(klassNaam);
                    }                    
                }                
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (lbKlas.SelectedItems.Count > 0)
            {
                string naam = "";
                if(txtNaam.Text.Trim().Length > 0)
                {
                    naam = txtNaam.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Naam is leeg");
                }
                string geboorte = dtpDOB.Value.ToShortDateString();
                string geslacht = "";

                foreach(RadioButton item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        geslacht = item.Text;
                    }
                }

                if (naam.Length > 0)
                {
                    mijnSchool.KlasLijst[lbKlas.SelectedIndex].AddStudent(naam, geboorte, geslacht);
                    txtNaam.Clear();
                    dtpDOB.Value = DateTime.Now;
                    foreach (RadioButton item in groupBox1.Controls)
                    {
                        item.Checked = false;
                    }

                    if (mijnSchool.KlasLijst[lbKlas.SelectedIndex].StudentLijst.Count > 0)
                    {
                        lbStudent.Items.Clear();
                        foreach (var item in mijnSchool.KlasLijst[lbKlas.SelectedIndex].StudentLijst)
                        {
                            string studentDetail = item.Naam + " (" + item.GeboorteDatum + ") - " + item.Geslacht;
                            lbStudent.Items.Add(studentDetail);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kies een klas voor een persoon toevoegen");
            }
        }

        private void lbKlas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mijnSchool.KlasLijst[lbKlas.SelectedIndex].StudentLijst.Count > 0)
            {
                lbStudent.Items.Clear();
                foreach (var item in mijnSchool.KlasLijst[lbKlas.SelectedIndex].StudentLijst)
                {
                    string studentDetail = item.Naam + " (" + item.GeboorteDatum + ") - " + item.Geslacht;
                    lbStudent.Items.Add(studentDetail);
                }
            }
        }
    }
}
