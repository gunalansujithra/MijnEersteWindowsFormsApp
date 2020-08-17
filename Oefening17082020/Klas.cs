using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Klas
    {
        public string Jaar;
        public string Richting;
        public List<Persoon> StudentLijst = new List<Persoon>();

        public Klas(string jaar, string richting)
        {
            Jaar = jaar;
            Richting = richting;
        }

        public void AddStudent(string naam, string geboorteDatum, string geslacht)
        {
            Persoon nieuwePersoon = new Persoon(naam, geboorteDatum, geslacht);
            StudentLijst.Add(nieuwePersoon);
        }
    }
}
