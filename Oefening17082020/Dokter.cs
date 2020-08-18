using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Dokter
    {
        public string DrNaam;

        public List<Appointment> AppointmentLijst = new List<Appointment>();

        public Dokter(string drNaam)
        {
            DrNaam = drNaam;
        }

        public void AppointmentToevoegen(string naam, string date, string time)
        {
            Appointment newAppointment = new Appointment(naam, date, time);
            AppointmentLijst.Add(newAppointment);
        }
    }
}
