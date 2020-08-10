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
    public partial class oefening1 : Form
    {
        public oefening1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbNaam.Items.Add(txtNaam.Text);
            txtNaam.Clear();
        }

        private void oefening1_Load(object sender, EventArgs e)
        {

        }
    }
}
