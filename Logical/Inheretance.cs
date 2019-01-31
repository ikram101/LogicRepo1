﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
   public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }

        Address address = new Address();
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string StreetNo { get; set; }
        public string City { get; set; }

        public string PostalCode { get; set; }  

        public  Address()
        {

        }

    }


}