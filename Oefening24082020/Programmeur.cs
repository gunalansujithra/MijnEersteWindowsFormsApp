using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening24082020
{
    public class Programmeur : Werknemer
    {
        public string ProgrammeurTalen { get; set; }

        public double Btwpercentage { get; set; }   

        public Programmeur(string naam, string programmeurTalen, string land = "België", double btwpercentage = 21, double salaris = 2440.55) : base(naam, salaris, land)
        {
            Btwpercentage = btwpercentage;
            ProgrammeurTalen = programmeurTalen;
        }

        public double BerekenNetto()
        {
            double berekenNetto = Salaris + 123;
            berekenNetto = Math.Round(berekenNetto - (berekenNetto * (Btwpercentage / 100)), 2);
            berekenNetto += 50;
            return berekenNetto;
        }      

        public override string Beschrijf()
        {
            return base.Beschrijf() + $", Netto: {BerekenNetto()}, Programmeur Talen: {ProgrammeurTalen}";
        }
    }
}
