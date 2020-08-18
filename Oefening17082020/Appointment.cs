using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Appointment
    {
        public string Naam;
        public string Date;
        public string Time;

        public Appointment(string naam, string date, string time)
        {
            Naam = naam;
            Date = date;
            Time = time;
        }
    }
}
