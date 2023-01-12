using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Taskseven
    {
        public void Ervthmaepta()
        {
            double celsiusTemp = 11;
            double kelvinTemp = celsiusTemp + 273.15;
            double fahrenheitTemp = (celsiusTemp * 1.8) + 32;

            Console.WriteLine("Today's temperature is " + celsiusTemp + " Celsius, " + kelvinTemp + " Kelvin" + " and " + fahrenheitTemp + " Fahrenheit.");

        }
    }
}