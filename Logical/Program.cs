using System;
using System.Collections.Generic;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int a=1;a<=100;a++)
            {

                bool prime = myArray.IsPrimeNumber(a);
                if(prime)
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(a);
                }
            }


            Console.ReadKey();


        }
    }
}