using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Logical
{
    public class MyStrings
    {


        // Reverse string

        public static string ReverseArray01(string strInput)
        {
            string strTemp = string.Empty;
            int forward = 0;

            char[] chArray = strInput.ToCharArray();

            for (int a = strInput.Length - 1; a >= 0; a--)
            {
                chArray[forward++] = strInput[a];
            }

            return new string(chArray);

        }

        //A method can recive 3 or 4 char string as an aurg. if 3 char return 4 with leading zero
        // 134 then return 0134

        public static string PadLef4(string strInput)
        {

            if (strInput.Length == 3)
            {
                return ("0" + strInput);
            }
            else if (strInput.Length == 4)
            {
                return strInput;
            }
            else
            {
                return strInput;
            }

        }

        //Lef Pad string with leading zero

        public static string PadString(string strInput, char padChar, int noOfStuff)
        {

            // convert 234,0,5=> 00234
            if (strInput.Length < noOfStuff)
            {
                int count = noOfStuff + strInput.Length;
                string dd = strInput.PadLeft(count, padChar);

                return dd;
            }


            return strInput;
        }


        //Move blank spaces to the front 

        // [2][3][][][d][][][][55]
        // [][][][][][2][3][5]

        public static string[] RemoveBlankspaces(string[] strArr)
        {
            string[] temp = { "Hi", "", "Syed", "", "", "701" };

            Array.Sort(strArr);

            return strArr;
        }

        // Reflection 

        


        //Reflection string path= Home.Address.PostalCode  return postalcode value

        public static void GetPostalCode(string path = "Home.Address.PostalCode")
        {
            //Get postal code value using reflection


        }


        public void ArrayInilizationSamples()
        {

        }

       



        // Find most repeated char in a string



        //Work on recursive functions


        // Find factorial

        //Find Exponent

        // Remove duplicate from string


        static void Example01()
        {
            // Create new string from range of characters in array.
            char[] charArray = new char[6];
            charArray[0] = 'a';
            charArray[1] = 'B';
            charArray[2] = 'c';
            charArray[3] = 'D';
            charArray[4] = 'e';
            charArray[5] = 'F';

            string exampleString = new string(charArray, 0, 3);
            Console.WriteLine(exampleString);
            Console.WriteLine(exampleString == "aBc");
        }

        //C# program that converts List

        static void ConvertListToString()
        {
            List<string> dogs = new List<string>();
            dogs.Add("Aigi"); // Add string 1
            dogs.Add("Spitz"); // 2
            dogs.Add("Mastiff"); // 3
            dogs.Add("Finnish Spitz"); // 4
            dogs.Add("Briard"); // 5

            string dogCsv = string.Join(",", dogs.ToArray());
            Console.WriteLine(dogCsv);
        }

        //C# program that converts string to List

        static void ConvertStringToList()
        {
            string csv = "one,two,three"; // The input string
            string[] parts = csv.Split(','); // Call Split method
            List<string> list = new List<string>(parts); // Use List constructor
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }



    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }

        public int GetAge
        {

            get { return 12; }

        }
    }

     

}

