using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
    public class myArray
    {


        public static int[] ReverseMyArray()
        {
            int[] array1 = { 4, 4, 2, 2, 2, 2, 3, 3, 1, 1, 6, 7, 5 };


            int len = array1.Length-1;
            int[] temp = new int[len+1];


            int frd = 0;

            for (int a=len;a>=0;a--)
            {
                temp[frd++] = array1[a];
            }

            return temp;

        }


        // Sort Arry without using funtions

        public static int[] SortMyArray()
        {

            return new int[3];
        }


        // Find greatest number in an array

        public static int[] FindGreaterNumber()
        {

            return new int[3];
        }

        // Remove duplicates

        public static int[] RemoveDuplicateValues()
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
