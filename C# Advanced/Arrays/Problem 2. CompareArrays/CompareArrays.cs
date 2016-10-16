using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int lenght1 = int.Parse(Console.ReadLine());
            int lenght2 = int.Parse(Console.ReadLine());

            int[] array1 = new int[lenght1];
            int[] array2 = new int[lenght2];

            bool areEqual = true;


            if (lenght1 != lenght2)
            {
                Console.WriteLine("Not equal");
                
            }
            else if (lenght1 == lenght2)
            {

                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        array1[i] = int.Parse(Console.ReadLine());
                        array2[j] = int.Parse(Console.ReadLine());


                        if (array1[i] != array2[j])
                        {
                            areEqual = false;
                            Console.WriteLine("Not equal");
                            break;
                        }
                    }
                    if (areEqual == true)
                    {
                        Console.WriteLine("Equal");
                        break;
                    }
                }
            }
        }
    }
}
