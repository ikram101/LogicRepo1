using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logical
{
    public class myArray
    {


        public static int[] ReverseMyArray()
        {
            int[] array1 = { 4, 4, 2, 2, 2, 2, 3, 3, 1, 1, 6, 7, 5 };

            int len = array1.Length - 1;
            int[] temp = new int[len + 1];


            int frd = 0;

            for (int a = len; a >= 0; a--)
            {
                temp[frd++] = array1[a];
            }

            return temp;

        }


        // Sort Arry without using funtions

        public static int[] SortMyArray()
        {

            int[] array1 = { 4, 4, 2, 2, 2, 2, 3, 3, 1, 1, 6, 7, 5 };


            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1; j < (array1.Length - 1); j++)
                {
                    if (array1[j] < array1[i])
                    {
                        int temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }

            var xx = array1;

            return array1;
        }

        // Remove duplicates

        public static int[] myDuplicate()
        {
            int[] array1 = { 4, 4, 2, 2, 2, 2, 3, 3, 1, 1, 6, 7, 5 };

            List<int> array2 = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1; j < array1.Length - 1; j++)
                {
                    if (array1[i] == array1[j])
                    {
                        array2.Add(array1[i]);
                    }
                }

            }


            //List duplicate items
            array2.Sort();

            foreach (int i in array2)
            {
                int count = array2.Where(r => r == i).Count();
                Console.WriteLine($" {i} = Total = {count}");
            }


            return array1;
        }


        // Find greatest number in an array

        public static int[] FindGreaterOrSmallarNumber() 
        {
            int[] array1 = { 4, 2, 3, 2, 2, 2, 3, 3, 1, 1, 6, 7, 5 };

            for (int a = 0; a < array1.Length; a++)
            {
                for (int b = a + 1; b < array1.Length ; b++)
                {
                    if (array1[b] < array1[a])
                    {
                        int temp = array1[a];
                        array1[a] = array1[b];
                        array1[b] = temp;
                    }
                }
            }

            int gr = array1[array1.Length - 1];

            int greaterNum = array1.ToList().Max(n => n);


            return array1;
        }



        // Factoreal

        public static int FindFactoreal()
        {
            int number = 4;  // 4*3*2*1

            int fact = 1;

            for (int a = number; a >= 1; a--)
            {
                fact = fact * a;    //4*3
            }


            return fact;
        }

        // exponent
        public static int[] FindExponent()
        {

            //8^2= 8*8
            //8^3 =8*8*8

            int number = 8;
            int exp = 3;
            int result = 1;
            for (int a=1;a<=exp;a++)
            {
                result = result * number;
            }

            return new int[3];
        }


        // Yeild
        //IEnumrable
        //


    }
}
