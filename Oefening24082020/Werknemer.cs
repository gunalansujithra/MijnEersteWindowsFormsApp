using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening24082020
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public double Salaris { get; set; }
        public string Land { get; set; }

        public Werknemer(string naam, double salaris = 2440.55, string land = "Belgium")
        {
            Naam = naam;
            Salaris = salaris;
            Land = land;
        }

        public override string ToString()
        {
            return Naam;
        }

        public virtual string Beschrijf()
        {
            return $"Land: {Land}, Bruto: {Salaris}";
        }
    }
}
