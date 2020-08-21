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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {            
            if (cbRekeningType.SelectedIndex >= 0 && txtRekeningNummer.Text.Trim().Length > 0 && txtNaam.Text.Trim().Length > 0)
            {
                string rekeningNummer = "BE" + txtRekeningNummer.Text.Trim();
                if (cbRekeningType.SelectedItem.ToString() == "Debitrekening")
                {
                    Bank debit = new DebitRekening(rekeningNummer, txtNaam.Text.Trim(), 10000);
                    Home.mijnAccount.BankLijst.Add(debit);
                }
                else if (cbRekeningType.SelectedItem.ToString() == "Creditrekening")
                {
                    Bank credit = new CreditRekening(rekeningNummer, txtNaam.Text.Trim(), 10000, txtCvv.Text);
                    Home.mijnAccount.BankLijst.Add(credit);
                }
                else if (cbRekeningType.SelectedItem.ToString() == "Spaarrekening")
                {
                    Bank spaar = new SpaarRekening(rekeningNummer, txtNaam.Text.Trim(), 10000);
                    Home.mijnAccount.BankLijst.Add(spaar);
                }

                MessageBox.Show("Account created");

                txtRekeningNummer.Clear();
                txtNaam.Clear();
                txtCvv.Clear();
                cbRekeningType.SelectedIndex = -1;
                lblCvv.Visible = false;
                txtCvv.Visible = false;
            }            
            else if (txtRekeningNummer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter rekening number");
            }
            else if (txtNaam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter naam");
            }
            else if (cbRekeningType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a rekening type");
            }

        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            cbRekeningType.Items.Add("Debitrekening");
            cbRekeningType.Items.Add("Creditrekening");
            cbRekeningType.Items.Add("Spaarrekening");

            lblCvv.Visible = false;
            txtCvv.Visible = false;

        }

        private void cbRekeningType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRekeningType.SelectedIndex >= 0)
            {
                if (cbRekeningType.SelectedItem.ToString() == "Creditrekening")
                {
                    lblCvv.Visible = true;
                    txtCvv.Visible = true;
                }
                else
                {
                    lblCvv.Visible = false;
                    txtCvv.Visible = false;
                }
            }
        }

        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRekeningNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtRekeningNummer_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
