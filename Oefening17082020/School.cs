using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class School
    {
        public List<Klas> KlasLijst = new List<Klas>();

        public void AddKlas(string jaar, string richting)
        {
            Klas nieuweKlas = new Klas(jaar, richting);
            KlasLijst.Add(nieuweKlas);
        }
    }
}
