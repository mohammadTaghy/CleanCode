using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures_Clean
{
    public class Person
    {
        private string name { get; set; }
        private Address address { get; set; }

        public string GetName()
        {
            return name;
        }
        // A method that returns the street name of the person's address
        public string GetStreet()
        {
            return address.GetStreet();
        }

        // A method that returns the city name of the person's address
        public string GetCity()
        {
            return address.GetCity();
        }

        // A method that returns the zip code of the person's address
        public string GetZipCode()
        {
            return address.GetZipCode();
        }

    }
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;

        public string GetStreet()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetZipCode()
        {
            return zipCode;
        }

        
    }
    // A class that represents a printer
    public class Printer
    {
        // A method that prints the name and address of a person
        public void PrintPerson(Person person)
        {
            Console.WriteLine("Name: " + person.GetName());
            Console.WriteLine("Street: " + person.GetStreet()); // Follows the Law of Demeter
            Console.WriteLine("City: " + person.GetCity()); // Follows the Law of Demeter
            Console.WriteLine("Zip Code: " + person.GetZipCode()); // Follows the Law of Demeter
        }
    }
}
