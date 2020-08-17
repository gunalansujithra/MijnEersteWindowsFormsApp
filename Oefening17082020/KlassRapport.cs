using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class KlassRapport
    {
        public List<int> TaalLijst = new List<int>();
        public List<int> RekenenLijst = new List<int>();
        public List<int> ICTLijst = new List<int>();
        public List<int> GeschiedenisLijst = new List<int>();

        public KlassRapport()
        {

        }

        public void AddTaalLijst(int taal)
        {
            TaalLijst.Add(taal);
        }
        public void AddRekenenLijst(int rekenen)
        {
            RekenenLijst.Add(rekenen);
        }
        public void AddICTLijst(int ict)
        {
            ICTLijst.Add(ict);
        }
        public void AddGeschiedenisLijst(int geschiedenis)
        {
            GeschiedenisLijst.Add(geschiedenis);
        }

        public void RemoveTaalLijst(int index)
        {
            TaalLijst.RemoveAt(index);
        }
        public void RemoveRekenenLijst(int index)
        {
            RekenenLijst.RemoveAt(index);
        }
        public void RemoveICTLijst(int index)
        {
            ICTLijst.RemoveAt(index);
        }
        public void RemoveGescheidenisLijst(int index)
        {
            GeschiedenisLijst.RemoveAt(index);
        }

        public int GemiddeldeTaal()
        {
            int sum = 0;

            if (TaalLijst.Count > 0)
            {
                foreach(var item in TaalLijst)
                {
                    sum += item;
                }

                sum = sum / TaalLijst.Count;
            }
            return sum;
        }
        public int GemiddeldeGescheidenis()
        {
            int sum = 0;

            if (GeschiedenisLijst.Count > 0)
            {
                foreach (var item in GeschiedenisLijst)
                {
                    sum += item;
                }

                sum = sum / GeschiedenisLijst.Count;
            }
            return sum;
        }
        public int GemiddeldeRekenen()
        {
            int sum = 0;

            if (RekenenLijst.Count > 0)
            {
                foreach (var item in RekenenLijst)
                {
                    sum += item;
                }

                sum = sum / RekenenLijst.Count;
            }
            return sum;
        }
        public int GemiddeldeICT()
        {
            int sum = 0;

            if (ICTLijst.Count > 0)
            {
                foreach (var item in ICTLijst)
                {
                    sum += item;
                }

                sum = sum / ICTLijst.Count;
            }
            return sum;
        }
    }
}
