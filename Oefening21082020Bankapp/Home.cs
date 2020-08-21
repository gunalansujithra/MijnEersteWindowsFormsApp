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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public static Account mijnAccount = new Account();
        private void btnView_Click(object sender, EventArgs e)
        {
            ViewAccounts view = new ViewAccounts();
            view.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount add = new AddAccount();
            add.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Bank debit1 = new DebitRekening("BE23 2324 4364 4562", "Simoen", 10000);
            Bank debit2 = new DebitRekening("BE23 2324 5323 9355", "Filip", 10000);
            Bank credit1 = new CreditRekening("BE76 8653 5674 6473", "Daan", 10000, "234");
            Bank credit2 = new CreditRekening("BE76 3456 8254 3956", "Lucas", 10000, "644");
            Bank spaar1 = new SpaarRekening("BE45 6587 6836 2485", "Jesse", 10000);
            Bank spaar2 = new SpaarRekening("BE84 5634 3572 5463", "Tim", 10000);

            mijnAccount.BankLijst.Add(debit1);
            mijnAccount.BankLijst.Add(debit2);
            mijnAccount.BankLijst.Add(credit1);
            mijnAccount.BankLijst.Add(credit2);
            mijnAccount.BankLijst.Add(spaar1);
            mijnAccount.BankLijst.Add(spaar2);
        }
    }
}
