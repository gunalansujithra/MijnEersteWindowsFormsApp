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
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        private void Oefening4_Load(object sender, EventArgs e)
        {
            BindingList<User> user = new BindingList<User>();
            cbNaam.DisplayMember = "VoorNaam";
            cbNaam.ValueMember = "AchterNaam";

            user.Add(new User("---Select---", ""));
            user.Add(new User("Sujithra", "Gunalan"));
            user.Add(new User("Ken", "Field"));
            user.Add(new User("Latha", "Sowdi"));
            
            cbNaam.DataSource = user;            
            cbNaam.SelectedIndex = 0;
            
        }

        private void cbNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNaam.SelectedIndex > 0)
            {
                MessageBox.Show(cbNaam.SelectedValue.ToString());
            }
        }
    }

    public class User
    {
        public string VoorNaam { get; set; }
        public string AchterNaam { get; set; }

        public User(string voorNaam, string achterNaam)
        {
            VoorNaam = voorNaam;
            AchterNaam = achterNaam;
        }
    }
}
