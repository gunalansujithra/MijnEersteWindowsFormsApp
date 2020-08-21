using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening21082020Bankapp
{
    public class DebitRekening : Bank
    {
        public DebitRekening(string accountNumber, string ownerNaam, double balance) : base(accountNumber, ownerNaam, balance)
        {

        }
        public override string Beschrijf()
        {
            return base.Beschrijf();
        }
    }
}
