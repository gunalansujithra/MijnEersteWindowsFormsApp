using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening19082020ClassInheritance
{
    public class Composer : Artist
    {
        public string Genre { get; set; }

        public Composer(string title, double duration, string naam, string genre, List<string> instruments) : base(title, duration, naam, instruments)
        {
            Genre = genre;
        }

        public Composer(string title, double duration, string naam, string genre) : base(title, duration, naam)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + $" Genre is {Genre}.";
        }
    }
}
