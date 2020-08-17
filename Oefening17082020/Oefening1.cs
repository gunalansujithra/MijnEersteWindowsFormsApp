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
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        private Teller mijnTeller = new Teller();
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            mijnTeller.Bekijken();
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            mijnTeller.Verhogen();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            mijnTeller.Verlagen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mijnTeller.Reset();
        }
    }
}
