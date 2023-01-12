using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Taskthree
    {
        public void Ervthmatria()
        {
            double result = -1+(5*6);
            Console.WriteLine("-1 + (5*6)= " + result);

            result = 38 + (5 % 8);
            Console.WriteLine("38 + (5 % 8)= " + result);

            result = 14 + ((-3 * 6)/7);
            Console.WriteLine("14 + ((-3 * 6)/7)= " + result);
           
            double resultNew = 2 + ((13 / 6) * 6) + Math.Sqrt(7);
            Console.WriteLine("(2 + ((13 / 6) * 6) + √7)= " + resultNew);

            resultNew = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
            Console.WriteLine("(Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 mod 4)= " + resultNew);

        }
    }
}
