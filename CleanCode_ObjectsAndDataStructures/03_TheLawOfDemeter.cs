using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures
{
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
    // A class that represents a printer
    public class Printer
    {
        // A method that prints the name and address of a person
        public void PrintPerson(Person person)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Street: " + person.Address.Street); // Violates the Law of Demeter
            Console.WriteLine("City: " + person.Address.City); // Violates the Law of Demeter
            Console.WriteLine("Zip Code: " + person.Address.ZipCode); // Violates the Law of Demeter
        }
    }
}
