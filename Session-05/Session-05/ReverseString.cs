using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ReverseString
    {
        public string Returnname()
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter your name:");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Your name reversed is:");
            return reverse;
        }

    }
}