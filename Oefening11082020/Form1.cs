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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oefening1 oefen1 = new Oefening1();
            oefen1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oefening2 oefen2 = new Oefening2();
            oefen2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oefening3 oefen3 = new Oefening3();
            oefen3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oefening4 oefen4 = new Oefening4();
            oefen4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oefening5 oefen5 = new Oefening5();
            oefen5.Show();
        }
    }
}
