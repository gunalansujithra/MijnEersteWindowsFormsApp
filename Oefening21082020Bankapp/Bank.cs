using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening21082020Bankapp
{
    public class Bank
    {
        public string AccountNumber { get; set; }
        public string OwnerNaam { get; set; }
        public double Balance { get; set; }

        public List<Bank> BankList = new List<Bank>();

        public Bank(string accountNumber, string ownerNaam, double balance)
        {
            AccountNumber = accountNumber;
            OwnerNaam = ownerNaam;
            Balance = balance;
        }

        public virtual string Beschrijf()
        {
            string beschrijving = $"Account nummer: {AccountNumber}. Naam: {OwnerNaam}. Total balance: {Balance}.";            
            return beschrijving;
        }

        public override string ToString()
        {
            return AccountNumber;
        }


    }
}
