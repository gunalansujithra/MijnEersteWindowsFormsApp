using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Werknemer
    {
        public string Naam;
        public string GeboorteDatum;
        public string Geslacht;

        public Werknemer(string naam, string geboorteDatum, string geslacht)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }
    }
}
