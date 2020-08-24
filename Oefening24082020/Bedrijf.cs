using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening24082020
{
    public class Bedrijf
    {
        public string BedrijfNaam { get; set; }
        public List<Werknemer> WerknemersLijst;

        public Bedrijf(string bedrijfNaam)
        {
            BedrijfNaam = bedrijfNaam;
            WerknemersLijst = new List<Werknemer>();
        }

        public void WerknermerToevoegen(string naam, int selectedContract, double salary, string land, string talen, bool isProgrammeur)
        {
            Salaris.ContractType contractType;
            contractType = selectedContract == 0 ? Salaris.ContractType.Maandcontract : Salaris.ContractType.Weekcontract;
            if (isProgrammeur)
            {
                Werknemer werknemer = new Programmeur(naam, programmeurTalen: talen, land: land, salaris: salary);
                WerknemersLijst.Add(werknemer);
            }
            else
            {
                Werknemer werknemer = new Salaris(naam, contract: contractType, land: land, salaris: salary);
                WerknemersLijst.Add(werknemer);
            }           
        }

        public void WerkenemerVerwijderen(int index)
        {
            WerknemersLijst.RemoveAt(index);
        }

        public override string ToString()
        {
            return BedrijfNaam;
        }
    }
}
