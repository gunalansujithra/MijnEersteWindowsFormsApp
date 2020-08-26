using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening26082020
{
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        public Dictionary<int, string> number = new Dictionary<int, string>();
        private void Oefening1_Load(object sender, EventArgs e)
        {
            number.Add(1, "Een");
            number.Add(2, "Twee");
            number.Add(3, "Drie");
            number.Add(4, "Vier");
            number.Add(5, "Vijf");
            number.Add(6, "Zes");
            number.Add(7, "Zeven");
            number.Add(8, "Acht");
            number.Add(9, "Negen");
            number.Add(10, "Tien");

            foreach(KeyValuePair<int, string> item in number)
            {
                cbNummers.Items.Add(item.Key);
            }
        }

        private void cbNummers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> item in number)
            {
                if (item.Key == Convert.ToInt32(cbNummers.SelectedItem.ToString()))
                {
                    lblDisplay.Text = item.Value;
                }
            }
        }
    }
}
