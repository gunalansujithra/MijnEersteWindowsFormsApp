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
    public partial class _2DArraysOef1 : Form
    {
        public _2DArraysOef1()
        {
            InitializeComponent();
        }

        private void _2DArraysOef1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                decimal hour = -1;

                for (int j = 0; j < 25; j++)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Width = 80;
                    newTextBox.Name = $"textbox{i}{j}";
                    newTextBox.Location = new Point(10 + newTextBox.Width * i, 10 + 20 * j);

                    Controls.Add(newTextBox);

                    if (i == 0 && j == 0)
                        newTextBox.Enabled = false;

                    if (i == 1 && j == 0)
                    {
                        newTextBox.Text = "Maandag";
                        newTextBox.Enabled = false;
                    }

                    if (i == 2 && j == 0)
                    {
                        newTextBox.Text = "Dinsdag";
                        newTextBox.Enabled = false;
                    }
                    if (i == 3 && j == 0)
                    {
                        newTextBox.Text = "Woensdag";
                        newTextBox.Enabled = false;
                    }
                    if (i == 4 && j == 0)
                    {
                        newTextBox.Text = "Donderdag";
                        newTextBox.Enabled = false;
                    }
                    if (i == 5 && j == 0)
                    {
                        newTextBox.Text = "Vrijdag";
                        newTextBox.Enabled = false;
                    }
                    if (i == 6 && j == 0)
                    {
                        newTextBox.Text = "Zaterdag";
                        newTextBox.Enabled = false;
                    }
                    if (i == 7 && j == 0)
                    {
                        newTextBox.Text = "Zondag";
                        newTextBox.Enabled = false;
                    }

                    if (i == 0 && j > 0)
                    {
                        newTextBox.Text = hour + ":00";
                        newTextBox.Enabled = false;
                    }
                    hour++;

                    if ((i == 1 || i == 2 || i == 4) && j > 8 && j < 17)
                        newTextBox.Text = "LES";

                    if (i == 3 && j > 13 && j < 19)
                        newTextBox.Text = "ZELFSTUDIE";

                    if (i == 5 && j > 9 && j < 13)
                        newTextBox.Text = "ZELFSTUDIE";

                    if (i == 7 && j > 15 && j < 19)
                        newTextBox.Text = "ZELFSTUDIE";

                    if (i == 4 && j > 19 && j < 22)
                        newTextBox.Text = "ZWEMLES";

                    if (i == 5 && j > 13 && j < 17)
                        newTextBox.Text = "BEGELEIDING";
                }
            }
        }
    }
}
