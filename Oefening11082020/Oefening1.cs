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
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbActive.Items.Add(txtNaam.Text);
            txtNaam.Clear();
        }

        private void Oefening1_Load(object sender, EventArgs e)
        {
            lbActive.Items.Add("An");
            lbActive.Items.Add("Bart");
            lbActive.Items.Add("Geert");
            lbActive.Items.Add("Filip");

            lbInactive.Items.Add("Cedric");
            lbInactive.Items.Add("Dirk");
            lbInactive.Items.Add("Erik");
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            if (lbActive.SelectedItems.Count > 0)
            {
                string selectedItem = lbActive.SelectedItem.ToString();
                lbInactive.Items.Add(selectedItem);
                lbActive.Items.Remove(selectedItem);
            }
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            if (lbInactive.SelectedItems.Count > 0)
            {
                string selectedItem = lbInactive.SelectedItem.ToString();
                lbActive.Items.Add(selectedItem);
                lbInactive.Items.Remove(selectedItem);
            }
        }

        public void SwitchItems(ListBox active, ListBox inactive)
        {

        }
    }

    
}
