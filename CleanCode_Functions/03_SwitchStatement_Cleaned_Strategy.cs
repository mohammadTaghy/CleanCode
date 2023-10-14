using CleanCode_Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_Functions
{

    public class EmployeeFactoryImpl
    {
        public Money MakeEmployee(ICalculate calculate)
        {
            return calculate.CalcPay();
        }
    }

    public interface ICalculate
    {
        Money CalcPay();
    }

}
