using System;
using System.Collections.Generic;
using System.Text;

namespace Logical.Entities
{
    public static class Employee
    {
        public static int Empid { get; set; }

        public static double GetAge(DateTime dob)
        {
            TimeSpan ts = DateTime.Now - dob;
            var age = ts.TotalDays / 365;

            return age;
        }


    }

    //Error: Cannot dirive from a static class
    //Error: Cannot declare instance method/pro in a static class

    //public class ContractEmployee:Employee
    //{

    //}

}
