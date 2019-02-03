using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
    public class MyGenerics
    {

      public static  IList<string> FindBobs(IEnumerable<string> names)
        {
            var bobs = new List<string>();

            foreach (var currName in names)
            {
                if (currName == "B")
                    bobs.Add(currName);
            }

            return bobs;
        }

       public static IEnumerable<string> FindBobs1(IEnumerable<string> names) 
        {
            foreach (var currName in names)
            {
                if (currName == "B")
                    yield return currName;
            }
        }
    }
}
