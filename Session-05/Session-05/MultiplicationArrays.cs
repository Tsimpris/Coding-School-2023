using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MultiplicationArrays
    {
        public void MulArrays()
        {
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            int[,] mulArray = new int[4, 4] { { 2, 4, 9, 12 }, { 2, 4, 9, 12 }, { 2, 4, 9, 12 }, { 2, 4, 9, 12 } };
            //int[] mulArray = new int[array1.Length * array2.Length ];

            Console.WriteLine("\n");
            Console.WriteLine("The new Array from the multiplication of Array1 and Array2 is:");

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    mulArray[i, j] = array1[i] * array2[j];
                    Console.WriteLine(mulArray[i, j]);
                }
            }
            /*foreach (int i in mulArray)
            {
                System.Console.Write("{0} ", i);
            }*/
        }
    }
}
