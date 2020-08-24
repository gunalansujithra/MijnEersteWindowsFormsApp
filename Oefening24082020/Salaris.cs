using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening24082020
{
    public class Salaris : Werknemer
    {
        public enum ContractType
        {
            Weekcontract,
            Maandcontract
        }

        public double Btwpercentage { get; set; }
        public ContractType Contract;

        public Salaris(string naam, string land = "België", double btwpercentage = 21, ContractType contract = ContractType.Maandcontract, double salaris = 2440.55) : base(naam, salaris, land)
        {
            Btwpercentage = btwpercentage;
            Contract = contract;
        }

        public double BerekenNetto()
        {
            double berekenNetto;
            berekenNetto = Math.Round(Salaris - (Salaris * (Btwpercentage / 100)), 2);
            return berekenNetto;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $", Netto: {BerekenNetto()}, Contract: {Contract}";
        }
    }
}
