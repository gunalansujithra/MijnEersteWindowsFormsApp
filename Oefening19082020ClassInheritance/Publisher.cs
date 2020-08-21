using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening19082020ClassInheritance
{
    public class Publisher : MusicAlbum
    {
        public int Jaar { get; set; }

        public Publisher(string title, double duration, int jaar, List<string> instruments) : base(title, duration, instruments)
        {
            Jaar = jaar;
        }

        public Publisher(string title, double duration, int jaar) : base(title, duration)
        {
            Jaar = jaar;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" Deze album is gepubliceerd in {Jaar}.";
        }
    }
}
