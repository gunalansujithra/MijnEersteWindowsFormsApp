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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private void dtpMijnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpMijnDateTimePicker.Value.ToString("dd/MM/yyyy"));
        }
    }
}
