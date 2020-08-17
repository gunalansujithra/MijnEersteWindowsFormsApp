using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Zwembad
    {
        public int Lengte = 0;
        public int Breedte = 0;
        public int Diepte = 0;

        public Zwembad()
        {

        }

        public int Calculate(int lengte, int breedte, int diepte)
        {
            return lengte * breedte * diepte;
        }
    }
}
