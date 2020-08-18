using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Ziekenhuis
    {
        public List<string> DokterLijst = new List<string>()
        {
            "Dr Simoens", "Dr Filip", "Dr Nicolas", "Dr Johan", "Dr Ampe"
        };

        public List<string> ConsultationUurLijst = new List<string>()
        {
            "9AM - 10AM", "10AM - 11AM", "11AM - 12PM", "2PM - 3PM", "3PM - 4PM", "4PM - 5PM"
        };

        public List<Dokter> DokterAfsprakenLijst = new List<Dokter>();

        public void DrAfsprakenToevoegen(string naam)
        {
            Dokter newDokter = new Dokter(naam);
            DokterAfsprakenLijst.Add(newDokter);
        }               
        
    }
}
