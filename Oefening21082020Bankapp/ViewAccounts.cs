using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening21082020Bankapp
{
    public partial class ViewAccounts : Form
    {
        public ViewAccounts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbType.Items.Add("Debitrekening");
            lbType.Items.Add("Creditrekening");
            lbType.Items.Add("Spaarrekening");
            BtnOverschrijven.Enabled = false;
            lblRekening.Visible = false;
            btnDelete.Visible = false;
        }

        private void lbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRekeningListBox(lbType.SelectedItem.ToString());
        }

        private void lbRekening_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayLabel();
        }

        public static List<string> RecipientLijst = new List<string>();
        public static string Sender = "";

        private void BtnOverschrijven_Click(object sender, EventArgs e)
        {
            RecipientLijst.Clear();
            foreach (var item in Home.mijnAccount.BankLijst)
            {
                if (lbRekening.SelectedItem.ToString() != item.AccountNumber.ToString())
                {
                    RecipientLijst.Add(item.AccountNumber.ToString());
                }
                else
                {
                    Sender = item.AccountNumber.ToString();
                }
            }

            Overschrijven overschrijven = new Overschrijven();

            if (overschrijven.ShowDialog() == DialogResult.OK)
            {
                DisplayLabel();
                SetRekeningListBox(lbType.SelectedItem.ToString());
            }
        }

        public void DisplayLabel()
        {
            Bank selectedRekening = (Bank)lbRekening.SelectedItem;

            if (lbRekening.DataSource != null)
            {
                lblRekening.Visible = true;
                lblRekening.Text = selectedRekening.Beschrijf();
                if (selectedRekening.Balance == 0 && lbType.SelectedItem.ToString() == "Debitrekening")
                {
                    btnDelete.Visible = true;
                }
                else
                {
                    btnDelete.Visible = false;
                }
            }
            else
            {
                btnDelete.Visible = false;
                lblRekening.Visible = false;
                lblRekening.Text = "";
            }
        }

        public void SetRekeningListBox(string selectedItem)
        {
            switch (selectedItem)
            {
                case "Debitrekening":
                    List<DebitRekening> debit = new List<DebitRekening>();

                    foreach (var item in Home.mijnAccount.BankLijst.OfType<DebitRekening>())
                    {
                        debit.Add(item);
                    }

                    lbRekening.DataSource = null;
                    lbRekening.DataSource = debit;
                    if (lbRekening.DataSource != null && lbRekening.Items.Count > 0)
                    {
                        BtnOverschrijven.Enabled = true;
                    }
                    else
                    {
                        BtnOverschrijven.Enabled = false;
                    }
                    
                    break;

                case "Creditrekening":
                    List<CreditRekening> credit = new List<CreditRekening>();

                    foreach (var item in Home.mijnAccount.BankLijst.OfType<CreditRekening>())
                    {
                        credit.Add(item);
                    }

                    lbRekening.DataSource = null;
                    lbRekening.DataSource = credit;
                    BtnOverschrijven.Enabled = true;
                    break;

                case "Spaarrekening":
                    List<SpaarRekening> spaar = new List<SpaarRekening>();

                    foreach (var item in Home.mijnAccount.BankLijst.OfType<SpaarRekening>())
                    {
                        spaar.Add(item);
                    }

                    lbRekening.DataSource = null;
                    lbRekening.DataSource = spaar;
                    BtnOverschrijven.Enabled = false;
                    break;

                default:

                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = -1;
            int selectedIndex = -1;
            foreach(var item in Home.mijnAccount.BankLijst)
            {
                index++;
                if (item.AccountNumber == lbRekening.SelectedItem.ToString())
                {
                    selectedIndex = index;
                }
            }

            Home.mijnAccount.BankLijst.RemoveAt(selectedIndex);

            DisplayLabel();
            SetRekeningListBox(lbType.SelectedItem.ToString());
            if (lbRekening != null && lbRekening.SelectedItems.Count > 0)
            {
                BtnOverschrijven.Enabled = true;
            }
            else
            {
                BtnOverschrijven.Enabled = false;
            }
        }
    }
}
