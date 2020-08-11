using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening11082020
{
    public partial class Oefening5 : Form
    {
        public Oefening5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text.Trim().Length > 0)
            {
                lbNaam.Items.Add(txtNaam.Text.Trim());
                txtNaam.Clear();
            }
            else
            {
                MessageBox.Show("Textbox is leeg");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbNaam.Items.Remove(lbNaam.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbNaam.Items.Count > 0)
            {
                if (!File.Exists("Oefening5.txt"))
                {
                    File.Delete("Oefening5.txt");
                }
                using (StreamWriter writer1 = new StreamWriter("Oefening5.txt"))
                {
                    foreach (var item in lbNaam.Items)
                    {
                        writer1.WriteLine(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geen gegevens om op te slaan.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("Oefening5.txt"))
            {
                lbNaam.Items.Clear();
                using (StreamReader reader = new StreamReader("Oefening5.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        lbNaam.Items.Add(reader.ReadLine());
                    }
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Er staat geen file");
            }           

        }
    }
}
