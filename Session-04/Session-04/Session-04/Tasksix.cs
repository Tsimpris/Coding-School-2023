using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Tasksix
    {
        public void Ervthmaexi()
        {
            System.Int32 randomNumber = 63113904;
            System.Int32 minutes = randomNumber / 60;
            System.Int32 hours = randomNumber / 3600;
            System.Int32 days = randomNumber / 86400;
            System.Int32 years = randomNumber / 31556952;

            Console.WriteLine(" 63,113,904 seconds is... " + " Minutes:" + minutes + " ,Hours:" + hours + " ,Days:" + days + " ,Years:" + years);

        }
    }
}