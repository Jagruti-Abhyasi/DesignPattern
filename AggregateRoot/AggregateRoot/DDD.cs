using System;
using System.Collections.Generic;
using System.Text;

namespace AggregateRoot
{
    //Entity Class
    public class Supplier
    {
        // Agrrgeation 1 to many
        private List<Address> _Addresses { get; set; }

        public void Add(Address obj)
        {
            // Add validation here 
            _Addresses.Add(obj);
        }
        //public Dal _dal { get; set; } // ur entity class is using data access layer , which is bad -- Read Note 1)
        // if ur Dal class will change then supplier class also has to change
    }
    public class Address
    {

    }
    //Entity Class
    public class Customer
    {

    }
    public class Dal
    {

    }

}
