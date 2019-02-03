using System;
using System.Collections.Generic;
using System.Text;

namespace Logical.Entities
{
    public interface IVehicle
    {
        string name { get; set; }
        string price { get; set; }
        string model { get; set; }

        void WelcomeMsg();
    }

    public interface ICar : IVehicle
    {
        string seating_capacity { get; set; }
    }

    public class Car : ICar
    {
        public string seating_capacity { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string model { get; set; }

        public void WelcomeMsg()
        {

        }
    }

    public class BMW:Car
    {
        public int BMWID { get; set; }
    }




    public class Test
    {
        BMW bmw = new BMW();
         
        public void test1()
        {
             
        }
    }

}
