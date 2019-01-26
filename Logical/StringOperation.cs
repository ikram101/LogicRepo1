using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
   public  class StringOperation
    {
        // Reverse string

        public static string ReverseArray01(string strInput)
        {
            string strTemp = string.Empty;
            int forward = 0;

            char[] chArray = strInput.ToCharArray();

            for (int a= strInput.Length-1; a>=0; a--)
            {
                chArray[forward++] = strInput[a];
            }

            return new string( chArray);

        }

    }
}
