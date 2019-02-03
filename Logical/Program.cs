using System;
using System.Collections.Generic;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> m_oEnum = new string[] {"AA","B","C","B","B","F" };
             

            List<string> m_oEnum2 =new List<string>();
            foreach (var x in MyGenerics.FindBobs1(m_oEnum))
            {
                m_oEnum2.Add(x);
            }
             

            ;
        }
    }
}