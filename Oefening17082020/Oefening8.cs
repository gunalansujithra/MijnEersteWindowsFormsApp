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
    public partial class Oefening8 : Form
    {
        public Oefening8()
        {
            InitializeComponent();
        }

        private DansLesson mijnDansLesson = new DansLesson();

        private void txtLeeftijd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
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
            int leeftijd = 0;
            if (txtLeeftijd.Text.Trim().Length > 0)
            {
                leeftijd = Convert.ToInt32(txtLeeftijd.Text.Trim());
            }
            else
            {
                MessageBox.Show("Leeftijd is leeg");
            }
            string geslacht = "";

            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    geslacht = item.Text;
                }
            }

            if (naam.Length > 0 && leeftijd > 0 && geslacht.Length > 0)
            {
                mijnDansLesson.AddDansStudent(naam, leeftijd, geslacht);
                txtNaam.Clear();
                txtLeeftijd.Clear();
                foreach (RadioButton item in groupBox1.Controls)
                {
                    item.Checked = false;
                }

                DisplayStudenten();
            }
        }

        public void DisplayStudenten()
        {
            if (mijnDansLesson.DansStudentLijst.Count > 0)
            {
                lbStudent.Items.Clear();
                foreach (var item in mijnDansLesson.DansStudentLijst)
                {
                    lbStudent.Items.Add(item.Naam);
                }
            }
            else
            {
                lbStudent.Items.Clear();
            }
        }

        private void btnKies_Click(object sender, EventArgs e)
        {
            if (mijnDansLesson.DansStudentLijst.Count > 6)
            {
                List<string> selectedStudenten = mijnDansLesson.KiesDansStudenten();

                string student = "Geselecteerde student zijn: ";

                foreach (var item in selectedStudenten)
                {
                    student += "\r\n" + item;
                }

                MessageBox.Show(student);
            }
            else
            {
                MessageBox.Show("Aantal studenten is minder dan 6");
            }
        }
    }
}
