using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnEersteWindowsFormsApp
{
    public partial class OefeningKlas : Form
    {
        public OefeningKlas()
        {
            InitializeComponent();
        }

        private void OefeningKlas_Load(object sender, EventArgs e)
        {
            cbLeerlingen.Items.Add("Sujithra");
            cbLeerlingen.Items.Add("Koen");
            cbLeerlingen.Items.Add("Latha");
            cbLeerlingen.Items.Add("Antal");
            cbLeerlingen.Items.Add("Martijn");

            foreach (var item in cbLeerlingen.Items)
            {
                lbLeerlingen.Items.Add(item);
            }
        }

        private void cbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLeerlingen.SelectedIndex.ToString());
            lblMijnLabel.Text = cbLeerlingen.SelectedItem.ToString();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbLeerlingen.Items.Add(txtMijnText.Text);
            txtMijnText.Clear();
        }

        private void btnMijnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
