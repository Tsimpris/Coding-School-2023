using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Taskfive
    {
        public void Ervthmapente()
        {
            int randomNumber = 63113904;
            int minutes = randomNumber / 60;
            int hours = randomNumber / 3600;
            int days = randomNumber / 86400;
            int years = randomNumber / 31556952;

            Console.WriteLine(" 63,113,904 seconds is... " + " Minutes: " + minutes +" ,Hours: "+ hours +" ,Days: "+ days +" ,Years: "+ years);

        }
    }
}
