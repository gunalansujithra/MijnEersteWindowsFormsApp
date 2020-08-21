using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening21082020Bankapp
{
    public partial class Overschrijven : Form
    {
        public Overschrijven()
        {
            InitializeComponent();
        }

        private void Overschrijven_Load(object sender, EventArgs e)
        {
            List<string> recipient = new List<string>();
            cbRekeningNummer.DataSource = null;
            cbRekeningNummer.DataSource = ViewAccounts.RecipientLijst;

            cbRekeningNummer.SelectedIndex = -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string senderAccount = ViewAccounts.Sender;
            if (cbRekeningNummer.SelectedIndex < 0)
            {
                MessageBox.Show("Select a rekening nummer");
            }
            double amount = 0;
            double minimumBalance = 0;
            bool isDebit = false;

            foreach (var item in Home.mijnAccount.BankLijst.OfType<DebitRekening>())
            {
                if (item.AccountNumber == senderAccount)
                {
                    minimumBalance = item.Balance;
                    isDebit = true;
                }
            }


            if (txtAmount.Text.Trim().Length < 1)
            {
                MessageBox.Show("Enter amount to be transfered");
            }
            else
            {
                amount = Convert.ToDouble(txtAmount.Text.Trim());

                if (isDebit && amount > minimumBalance)
                {
                    MessageBox.Show("Entered value is greater than minimum balance (" + minimumBalance + ")");
                }
                else
                {
                    foreach (var item in Home.mijnAccount.BankLijst)
                    {
                        if (item.AccountNumber == senderAccount)
                        {
                            item.Balance -= amount;                            
                        }
                        if (item.AccountNumber == cbRekeningNummer.SelectedItem.ToString())
                        {
                            item.Balance += amount;
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
