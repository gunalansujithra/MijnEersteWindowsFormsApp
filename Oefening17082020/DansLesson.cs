using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class DansLesson
    {
        public List<DansStudent> DansStudentLijst = new List<DansStudent>();

        public void AddDansStudent(string naam, int leeftijd, string geslacht)
        {
            DansStudent dansStudent = new DansStudent(naam, leeftijd, geslacht);
            DansStudentLijst.Add(dansStudent);
        }

        public List<string> KiesDansStudenten()
        {
            List<string> student = new List<string>();
            Random rand = new Random();
            
            if (DansStudentLijst.Count > 6)
            {
                List<string> selectedLijst = DansStudentLijst.Select(x => x.Naam).ToList();

                for (int i=0; i<6; i++)
                {
                    int index = rand.Next(0, selectedLijst.Count);
                    student.Add(selectedLijst[index]);
                    selectedLijst.RemoveAt(index);
                }
            }

            return student;
        }
    }
}
