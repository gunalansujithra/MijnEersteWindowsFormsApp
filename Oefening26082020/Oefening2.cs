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
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }

        //public static Dictionary<string, string> number1 = new Dictionary<string, string>();
        public static Dictionary<string, Taal> number = new Dictionary<string, Taal>();
               
        private void Oefening2_Load(object sender, EventArgs e)
        {
            //number.Add("Een", "One");
            //number.Add("Twee", "Two");
            //number.Add("Drie", "Three");
            //number.Add("Vier", "Four");
            //number.Add("Vijf", "Five");
            //number.Add("Zes", "Six");
            //number.Add("Zeven", "Seven");
            //number.Add("Acht", "Eight");
            //number.Add("Negen", "Nine");
            //number.Add("Tien", "Ten");

            Taal taal1 = new Taal("One", "Un", "Eins", "Uno", "Uno");
            Taal taal2 = new Taal("Two", "Deux", "Zwei", "Dos", "Due");
            Taal taal3 = new Taal("Three", "Trois", "Drei", "Tres", "Tre");
            Taal taal4 = new Taal("Four", "Quatre", "Vier", "Cuatro", "Quattro");
            Taal taal5 = new Taal("Five", "Cinq", "Fünf", "Cinco", "Cinque");
            Taal taal6 = new Taal("Six", "Six", "Sechs", "Seis", "Sei");
            Taal taal7 = new Taal("Seven", "Sept", "Sieben", "Siete", "Sette");
            Taal taal8 = new Taal("Eight", "Huit", "Acht", "Ocho", "Otto");
            Taal taal9 = new Taal("Nine", "Neuf", "Neun", "Nueve", "Nove");
            Taal taal10 = new Taal("Ten", "Dix", "Zehn", "Diez", "Dieci");
            
            number.Add("Een", taal1);
            number.Add("Twee", taal2);
            number.Add("Drie", taal3);
            number.Add("Vier", taal4);
            number.Add("Vijf", taal5);
            number.Add("Zes", taal6);
            number.Add("Seven", taal7);
            number.Add("Acht", taal8);
            number.Add("Negen", taal9);
            number.Add("Tien", taal10);

            
            foreach (KeyValuePair<string, Taal> item in number)
            {
                cbNummers.Items.Add(item.Key);                  
            }            
        }

        private void cbNummers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Taal> item in number)
            {
                if (item.Key == cbNummers.SelectedItem.ToString())
                {
                    lblEngels.Text = "Engels: " + item.Value.Engels;
                    lblFrans.Text = "Frans: " + item.Value.French;
                    lblDuitse.Text = "Duitse: " + item.Value.Duits;
                    lblSpaans.Text = "Spaans: " + item.Value.Spaans;
                    lblItaliaans.Text = "Italiaans: " + item.Value.Italiaans;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbNummers.SelectedIndex >= 0)
            {
                string key = "";
                foreach (KeyValuePair<string, Taal> item in number)
                {
                    if (item.Key == cbNummers.SelectedItem.ToString())
                    {
                        key = item.Key;
                    }
                }
                number.Remove(key);

                RefreshCombobox();
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oefening2b addForm = new Oefening2b();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshCombobox();
            }
        }

        public void RefreshCombobox()
        {
            cbNummers.Items.Clear();
            foreach (KeyValuePair<string, Taal> item in number)
            {
                cbNummers.Items.Add(item.Key);
            }
            cbNummers.Text = "";
            cbNummers.SelectedIndex = -1;
            lblEngels.Text = "";
            lblFrans.Text = "";
            lblDuitse.Text = "";
            lblSpaans.Text = "";
            lblItaliaans.Text = "";
        }

        public class Taal
        {
            public string Engels { get; set; }
            public string French { get; set; }
            public string Duits { get; set; }
            public string Spaans { get; set; }
            public string Italiaans { get; set; }

            public Taal(string engels, string french, string duits, string spaans, string italiaans)
            {
                Engels = engels;
                French = french;
                Duits = duits;
                Spaans = spaans;
                Italiaans = italiaans;
            }
        }
    }
}
