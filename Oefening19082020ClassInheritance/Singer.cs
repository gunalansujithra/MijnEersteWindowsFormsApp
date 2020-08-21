using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening19082020ClassInheritance
{
    public class Singer : Artist
    {
        public int Rating { get; set; }

        public Singer(string title, double duration, string naam, int rating, List<string> instruments) : base(title, duration, naam, instruments)
        {
            Rating = rating;
        }

        public Singer(string title, double duration, string naam, int rating) : base(title, duration, naam)
        {
            Rating = rating;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" Rating is {Rating}.";
        }
    }
}
