using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class PrimeNumbers
    {
        public void PrimeNum() //change void
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter an integer number:");
            var numString = Console.ReadLine();
            int n = Convert.ToInt32(numString);
            int flag = 0;
            Console.WriteLine("The Prime Numbers from 1 to " + n + " are :");

            for (int i = 2; i <= n; i++)
            {
                flag = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    //Console.WriteLine(i + " ");
                    Console.Write(i + ", ");

                }
            }

            //Testing a new mathod above
            /*for (int i =2; i<=n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
                if (a == 2)
                {
                    Console.WriteLine("{0} is a Prime number", n);
                }
                else
                {
                    Console.WriteLine("Not a Prime number");
                }
            }*/

        }
    }
}