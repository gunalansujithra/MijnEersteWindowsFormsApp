using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oefening19082020ClassInheritance
{
    public class Artist : MusicAlbum
    {
        public string Naam { get; set; }

        public Artist(string title, double duration, string naam, List<string> instruments) : base(title, duration, instruments)
        {
            Naam = naam;
        }

        public Artist(string title, double duration, string naam) : base(title, duration)
        {
            Naam = naam;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" Artist heet {Naam}.";
        }
    }
}
