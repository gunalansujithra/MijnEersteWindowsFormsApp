using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening17082020
{
    class Televisie
    {
        public int MijnVolume = 0;
        public int mijnChannel = 0;

        public List<string> KanaalLijst = new List<string>()
        { "BBC", "FOX", "CNN", "History", "Discovery", "HBO", "Disney", "Cartoon Network", "Comedy TV", "ABC"};

        public Televisie()
        {

        }

        public string DisplayKanaal(int index)
        {
            string selectedKanaal = "";
            selectedKanaal = KanaalLijst[index].ToString();

            return selectedKanaal;
        }
        public void ChannelVerhogen()
        {
            if (mijnChannel < 9)
            {
                mijnChannel++;
            }
        }

        public void ChannelVerlagen()
        {
            if (mijnChannel > 0)
            {
                mijnChannel--;
            }
        }

        public void VolumeVerhogen()
        {
            if(MijnVolume < 15)
            {
                MijnVolume++;
            }
        }

        public void VolumeVerlagen()
        {
            if(MijnVolume > 0)
            {
                MijnVolume--;
            }
        }
    }
}
