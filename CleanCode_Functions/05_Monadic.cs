using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_Functions
{
    internal class _04_Functions_Monadic
    {
        //question function
        bool FunctionBackBool(int param1)
        {
            return true;
        }
        public static bool isEmpty(string param)
        {
            return param == null || param.Length == 0;
        }
        //transform inputparam
        public static string trim(string text)
        {
            return text.Trim();
        }
        // event function
        public void Insert(Student student)
        {

        }
        public void LogError(string error)
        {
            Console.Error.WriteLine(error);
        }
        public class Student
        {

        }
        //flag Pramaeter
        public void FlagParameter(bool flag)
        {
            if (flag)
            {

            }
            else
            {

            }
        }
    }
}
