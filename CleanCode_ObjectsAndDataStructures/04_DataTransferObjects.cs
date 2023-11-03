using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_ObjectsAndDataStructures.DTO
{
    public record PersonDTO(string Name, int Age, string Address, string Phone);
    public class Person
    {
        private string name;
        private int age;
        private string address;
        private string phone;

        public Person(string name, int age, string address, string phone)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.phone = phone;
        }

       
        
    }
}
