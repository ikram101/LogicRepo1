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
                for (int j = i + 1; j < (array1.Length-1); j++)
                {
                    if (array1[j] < array1[i])
                    {
                        int temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }

           var xx= array1;

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

        public static int[] FindGreaterNumber()
        {

            return new int[3];
        }

       

        // Factoreal

        public static int[] FindFactoreal()
        {

            return new int[3];
        }

        // exponent
        public static int[] FindExponent()
        {

            return new int[3];
        }


        // Yeild
        //IEnumrable
        //


    }
}
