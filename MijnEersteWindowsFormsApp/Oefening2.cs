using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnEersteWindowsFormsApp
{
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }

        public int selectedValue = -1;

        private void cbMijnCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedText = cbMijnCombo.SelectedItem.ToString();            
            //cbMijnCombo.Items.RemoveAt(cbMijnCombo.SelectedIndex);
            //cbMijnCombo.Text = selectedText;
            selectedValue = cbMijnCombo.SelectedIndex;
        }

        private void Oefening2_Load(object sender, EventArgs e)
        {
            cbMijnCombo.Items.Add("Brugge");
            cbMijnCombo.Items.Add("Gent");
            cbMijnCombo.Items.Add("Antwerpen");
            cbMijnCombo.Items.Add("Brussel");
            cbMijnCombo.Items.Add("Leuven");
        }

        private void cbMijnCombo_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedValue >= 0 && cbMijnCombo.Items.Count > 0)
            {
                cbMijnCombo.Items.RemoveAt(selectedValue);
            }
            else
            {
                cbMijnCombo.Text = "";
            }
        }
    }
}
