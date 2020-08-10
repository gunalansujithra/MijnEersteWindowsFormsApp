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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oefening1 oefen1 = new oefening1();
            oefen1.Show();
        }

        private void btnOefening2_Click(object sender, EventArgs e)
        {
            Oefening2 oefen2 = new Oefening2();
            oefen2.Show();
        }

        private void btnOefening3_Click(object sender, EventArgs e)
        {
            Oefening3 oefen3 = new Oefening3();
            oefen3.Show();
        }

        private void btnOefening4_Click(object sender, EventArgs e)
        {
            Oefening4 oefen4 = new Oefening4();
            oefen4.Show();
        }

        private void btnOefeningLes_Click(object sender, EventArgs e)
        {
            OefeningKlas oefenKlas = new OefeningKlas();
            oefenKlas.Show();
        }
    }
}
