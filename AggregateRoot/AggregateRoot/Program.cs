using System;

namespace AggregateRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Supplier obj = new Supplier();
            Address a = new Address(); // <----- Independently not allowed 
                                       //obj.Addresses(a); // this is not aggregate root, because you are able to create and manipulate the child object Independently
                                       // this is not allowed in agrrgeate root    
            obj.Add(a); // this is agrrgeate root pattern
        }
    }
}
