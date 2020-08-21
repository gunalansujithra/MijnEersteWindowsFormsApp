using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening19082020ClassInheritance
{
    public class MusicAlbum
    {
        public string Title { get; set; }
        public double Duration { get; set; }
        public List<string> Instruments { get; set; }

        public MusicAlbum(string title, double duration, List<string> instruments)
        {
            Title = title;
            Duration = duration;
            Instruments = instruments;
        }

        public MusicAlbum(string title, double duration)
        {
            Title = title;
            Duration = duration;
            Instruments = new List<string>();
        }

        public virtual string Beschrijf()
        {
            string beschrijving;
            if (Instruments.Count != 0)
            {
                beschrijving = $"Deze muziek album heet {Title}. Hun duration is {Duration} minuten met instruments";
                foreach (var item in Instruments)
                {
                    beschrijving += " " + item;
                }
                beschrijving += ". ";
            }
            else
            {
                beschrijving = $"Deze muziek album heet {Title}. Hun duration is {Duration} minuten.";
            }
            return beschrijving;

        }

        public override string ToString()
        {
            return Title;
        }
    }
}
