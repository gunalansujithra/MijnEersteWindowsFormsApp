using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening11082020
{
    class Notitie
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }

        public Notitie(string naam, string beschrijving)
        {
            Naam = naam;
            Beschrijving = beschrijving;
        }
    }
}
