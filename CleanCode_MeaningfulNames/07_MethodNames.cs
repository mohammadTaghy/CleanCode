using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_MeaningfulNames
{
    internal class MethodNames
    {
        //Correct
        void postPayment() { }
        void deletePage() { }
        void save() { }
        //incorrect
        void payment() { }
    }
    class Complex
    {
        int number;
        public Complex(int number) { this.number = number; }

        void FromRealNumber(int number)
        {

            this.number = number;
        }
    }
    class Product
    {
        string name;
        string description;
        int cultureId;
        public Product() { }
        public Product(string name, string description)
        {
            this.name = name;

            this.description = description;
            cultureId = CultureInfo.CurrentCulture.LCID;
        }
        public static Product CreateProductWithDefaultCulture(string name, string description)
        {
            return new Product
            {
                name = name,
                description = description,
                cultureId = CultureInfo.CurrentCulture.LCID
            };
        }
    }
   
}
