using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
    public class MyGenerics
    {

        IList<string> FindBobs(IEnumerable<string> names)
        {
            var bobs = new List<string>();

            foreach (var currName in names)
            {
                if (currName == "Bob")
                    bobs.Add(currName);
            }

            return bobs;
        }

        IEnumerable<string> FindBobs1(IEnumerable<string> names)
        {
            foreach (var currName in names)
            {
                if (currName == "Bob")
                    yield return currName;
            }
        }
    }
}
