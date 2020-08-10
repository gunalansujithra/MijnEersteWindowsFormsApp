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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        public List<string> naamLijst;

        private void Oefening3_Load(object sender, EventArgs e)
        {
            naamLijst = new List<string>() { "An", "Bart", "Cedric", "Dieter", "Evert", "Filip", "Gert", "Henk" };
            lbNaam.DataSource = naamLijst;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lbNaam.DataSource = null;
            List<string> selectedList = new List<string>();

            foreach(var item in naamLijst)
            {
                if (item.ToLower().Contains(txtLetter.Text.ToLower()))
                {
                    selectedList.Add(item);
                }
            }            
            
            lbNaam.DataSource = selectedList;
            naamLijst.Clear();
            naamLijst = selectedList;            
        }
    }
}
