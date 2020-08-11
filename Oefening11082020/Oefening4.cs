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
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        NotitieBoekje nBoekje = new NotitieBoekje();
                
        private void btnLamineren_Click(object sender, EventArgs e)
        {
            lbNotities.Enabled = false;
            btnVoegNotitie.Enabled = false;
            btnScheurNotitie.Enabled = false;
            txtBijschrijven.Enabled = false;
            btnBijschrijven.Enabled = false;
        }

        private void btnBijschrijven_Click(object sender, EventArgs e)
        {
            nBoekje.NotitieBewerken(lbNotities.SelectedIndex, txtBijschrijven.Text.Trim());
            txtNotite.Text = nBoekje.NotitieLijst[lbNotities.SelectedIndex].Beschrijving.ToString();
            txtBijschrijven.Clear();
        }

        private void btnScheurNotitie_Click(object sender, EventArgs e)
        {
            if (lbNotities.SelectedIndex >= 0)
            {
                nBoekje.NotitieVerwijderen(lbNotities.SelectedIndex);
                DisplayNotitieBoekje();
            }
        }

        private void Oefening4_Load(object sender, EventArgs e)
        {
        }

        public static string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Notitie Naam",
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 10, Top = 10, Width = 270 };
            Button confirmation = new Button() { Text = "Ok", Left = 160, Width = 120, Top = 50, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btnVoegNotitie_Click(object sender, EventArgs e)
        {
            string naam = ShowDialog();
            string bijschrijven = txtBijschrijven.Text.Trim().Length > 0 ? txtBijschrijven.Text.Trim() : "";
            nBoekje.NotiteToevoegen(naam, bijschrijven);
            DisplayNotitieBoekje();
        }

        public void DisplayNotitieBoekje()
        {
            if (nBoekje.NotitieLijst.Count > 0)
            {
                List<string> naamLijst = new List<string>();

                foreach(var item in nBoekje.NotitieLijst)
                {
                    naamLijst.Add(item.Naam.ToString());
                }

                lbNotities.DataSource = naamLijst;
            }
            else
            {
                lbNotities.DataSource = null;
            }
        }

        private void lbNotities_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNotite.Text = nBoekje.NotitieLijst[lbNotities.SelectedIndex].Beschrijving.ToString();
        }
    }
}
