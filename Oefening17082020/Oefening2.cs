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
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }

        private Televisie mijnTelevisie = new Televisie();
        private void btnVolPlus_Click(object sender, EventArgs e)
        {
            mijnTelevisie.VolumeVerhogen();
            DisplayLabel();
        }

        private void btnVolMin_Click(object sender, EventArgs e)
        {
            mijnTelevisie.VolumeVerlagen();
            DisplayLabel();
        }

        private void Oefening2_Load(object sender, EventArgs e)
        {
            DisplayLabel();
        }

        public void DisplayLabel()
        {
            lblDisplayText.Text = "Volume: " + mijnTelevisie.MijnVolume + " Kanaal: " + mijnTelevisie.DisplayKanaal(mijnTelevisie.mijnChannel);
        }
        
        private void btnKanaal_Click(object sender, EventArgs e)
        {
            int kanaal = 0;
            if (txtKanaal.Text.Trim().Length > 0)
            {
                kanaal = Convert.ToInt32(txtKanaal.Text);
            }
            
            if (kanaal >= 0 && kanaal <= 9)
            {
                mijnTelevisie.mijnChannel = kanaal;
                DisplayLabel();
            }
            else
            {
                MessageBox.Show("Kies a kanaal tussen 0 tot 9");
            }
        }

        private void txtKanaal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKanaalPlus_Click(object sender, EventArgs e)
        {
            if (mijnTelevisie.mijnChannel <= 9)
            {
                mijnTelevisie.ChannelVerhogen();
                DisplayLabel();
            }
        }

        private void btnKanaalMin_Click(object sender, EventArgs e)
        {
            if (mijnTelevisie.mijnChannel >= 0)
            {
                mijnTelevisie.ChannelVerlagen();
                DisplayLabel();
            }
        }
    }
}
