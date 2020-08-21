using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening21082020Bankapp
{
    public class CreditRekening : Bank
    {
        public string CVV { get; set; }
        public CreditRekening(string accountNumber, string ownerNaam, double balance, string cvv) : base(accountNumber, ownerNaam, balance)
        {
            CVV = cvv;
        }
        public override string Beschrijf()
        {
            return base.Beschrijf() + $" CVV: {CVV}.";
        }

    }
}
