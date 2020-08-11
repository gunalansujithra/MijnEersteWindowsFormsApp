using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening11082020
{
    class NotitieBoekje
    {
        public List<Notitie> NotitieLijst = new List<Notitie>();

        public void NotiteToevoegen(string notitieNaam, string beschrijving)
        {
            Notitie notitie = new Notitie(notitieNaam, beschrijving);
            NotitieLijst.Add(notitie);
        }

        public void NotitieVerwijderen(int selectedIndex)
        {
            NotitieLijst.RemoveAt(selectedIndex);
        }

        public void NotitieBewerken(int selectedIndex, string beschrijving)
        {
            for (int i = 0; i < NotitieLijst.Count; i++)
            {
                if (i == selectedIndex)
                {
                    if (NotitieLijst[i].Beschrijving.Trim().Length > 0)
                    {
                        NotitieLijst[i].Beschrijving += ". " + beschrijving;
                    }
                    else
                    {
                        NotitieLijst[i].Beschrijving += beschrijving;
                    }
                }
            }
        }
    }
}
