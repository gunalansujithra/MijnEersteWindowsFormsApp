using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Attractie
    {
        public string Naam;
        public string Kleur;
        public int MinimumLeeftijd;
        public int MaximumAantalPersonen;

        public Attractie(string naam, string kleur, int minimumLeeftijd, int maximumAantalPersonen)
        {
            Naam = naam;
            Kleur = kleur;
            MinimumLeeftijd = minimumLeeftijd;
            MaximumAantalPersonen = maximumAantalPersonen;
        }
    }
}
