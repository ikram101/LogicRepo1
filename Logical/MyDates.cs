using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
    public static class MyDates
    {

        // Calculate Employee Age

        public static double GetAge()
        { 

            DateTime dob = new DateTime(1981,04,13);

            TimeSpan ts = DateTime.Now - dob;

            double age = ts.TotalDays / 365;

            return age;

        }

    }
}
