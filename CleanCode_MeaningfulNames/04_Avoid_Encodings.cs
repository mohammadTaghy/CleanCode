using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_MeaningfulNames
{
    internal class Avoid_Encodings
    {
        #region Hungarian Notation
        string strName = "";
        int intAge = 15;
        decimal dMoney;
        #endregion
    }
    #region Member Prefixes

    class User
    {
        string var_name = "";
        string var_telephon = "";
        string var_email = "";

        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }

    }
    #endregion
    #region Interfaces and Implementations


    interface IPerson { }
    class PersonImpl : IPerson { }
    class Person : IPerson { }
    class PersonInfo:Person { }
    class PersonCantact:Person { }


    interface Shape { }
    class Polygon:Shape { }

    #endregion

}
