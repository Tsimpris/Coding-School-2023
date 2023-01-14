using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class NumberTwoChoices
    {
        public int TwoChoises()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter an integer number:");
            var numString = Console.ReadLine();
            int n = Convert.ToInt32(numString);
            int sum = 0;
            int product = 1;
            int fanswer = 0;
            Console.WriteLine("Please enter <SUM> for Addition or <FACT> for factorial on your given number:");
            string answer = Console.ReadLine();
            if (answer == "sum")
            {
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("The addition of your given number is:");
                fanswer = sum;
            }
            else if (answer == "fact")
            {
                for (int i = 1; i <= n; i++)
                {
                    product = product * i;
                }
                Console.WriteLine("The factorial of your given number is:");
                fanswer = product;
            }
            return fanswer;

        }
    }
}