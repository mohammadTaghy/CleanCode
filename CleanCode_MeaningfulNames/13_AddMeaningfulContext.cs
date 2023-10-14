using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_MeaningfulNames
{
    internal class Order
    {
        public string State { get; set; }
    }
    class Address
    {
        public string State { get; set; }
        
    }
    class SampleClass
    {
        public SampleClass() { 
            Order order = new Order();
            order.State = "Draft";
            Address address = new Address();
            address.State = "Tehran";
        }
        void AddAddress(string state)
        {

        }
    }

}
