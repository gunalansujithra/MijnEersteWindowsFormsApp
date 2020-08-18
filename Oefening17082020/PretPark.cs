using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class PretPark
    {
        public string Naam;
        public List<Werknemer> WerknemerLijst = new List<Werknemer>();
        public List<Attractie> AttratieLijst = new List<Attractie>();

        public void WerknemerToevoegen(string naam, string geboorteDatum, string geslacht)
        {
            Werknemer nieuweWerknemer = new Werknemer(naam, geboorteDatum, geslacht);
            WerknemerLijst.Add(nieuweWerknemer);
        }

        public string WerknemerBekijken(int index)
        {
            string details = WerknemerLijst[index].Naam + "\r\n" + WerknemerLijst[index].GeboorteDatum + "\r\n" + WerknemerLijst[index].Geslacht;
            return details;
        }

        public void WerknemerVerwijderen(int index)
        {
            WerknemerLijst.RemoveAt(index);
        }

        public void AttractieToevoegen(string naam, string kleur, int minimumLeeftijd, int maximumAantalPersonen)
        {
            Attractie nieuweAttractie = new Attractie(naam, kleur, minimumLeeftijd, maximumAantalPersonen);
            AttratieLijst.Add(nieuweAttractie);
        }

        public void AttractieVerwijderen(int index)
        {
            AttratieLijst.RemoveAt(index);
        }

        public string AttractieBekijken(int index)
        {
            string details = AttratieLijst[index].Naam + "\r\n" + AttratieLijst[index].Kleur 
                    + "\r\n" + AttratieLijst[index].MinimumLeeftijd + "\r\n" + AttratieLijst[index].MaximumAantalPersonen;
            return details;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
