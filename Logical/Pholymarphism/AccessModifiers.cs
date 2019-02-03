using System;
using System.Collections.Generic;
using System.Text;

namespace Logical.Pholymarphism
{
    public class Vehicle
    {
        public string Pame { get; set; }
        protected string Price { get; set; }
        private string Model { get; set; }

        protected int x;

        public void WelcomeMsg()
        {

        }
    }

    public class Car:Vehicle
    {
        public string Vin { get; }

    
       
         
        public void test()
        {
            Car ca = new Car();
            string aa= ca.Price;
        }


    }

    public class Test01
    {
        Car carObj = new Car();

        Vehicle Vobj = new Vehicle();

        public void test()
        {
             
        }

        
    }


    public class Point
    {
        protected int x;
        protected int y;
    }

    public class DerivedPoint : Point
    {
         void Main()
        {
            DerivedPoint dpoint = new DerivedPoint();

            // Direct access to protected members:
            dpoint.x = 10;
            dpoint.y = 15;
            Console.WriteLine("x = {0}, y = {1}", dpoint.x, dpoint.y);
        }
    }
}
