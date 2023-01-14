using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class CustomSortMethod
    {
        public void CusSortMet()
        {
            int[] arrayS05t5 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            int arrayLength = arrayS05t5.Length;
            int temp = 0;
            Console.WriteLine("\n ");
            Console.WriteLine("The sorted array from the given array { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 } is:");
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i; j < arrayLength; j++)
                {
                    if (arrayS05t5[i] > arrayS05t5[j])
                    {
                        temp = arrayS05t5[i];
                        arrayS05t5[i] = arrayS05t5[j];
                        arrayS05t5[j] = temp;
                        //Console.WriteLine(arrayS05t5[i] + " ");
                        //Console.WriteLine(temp + ", ");
                    }

                }

            }
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(arrayS05t5[i]);
            }
        }
    }
}
