using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class SwitchStatement
    {
        public Money calculatePay(Employee employee)
        {
            switch (employee.Type)
            {
                case EmployeeType.COMMISSIONED:
                    return calculateCommissionedPay(employee);
                case EmployeeType.HOURLY:
                    return calculateHourlyPay(employee);
                case EmployeeType.SALARIED:
                    return calculateSalariedPay(employee);
                default:
                    throw new Exception("");
            }
        }
        Money calculateCommissionedPay(Employee employee) { return null; }
        Money calculateHourlyPay(Employee employee) { return null; }
        Money calculateSalariedPay(Employee employee) { return null; }
    }
    public class Money
    {

    }
    class Employee
    {
        public EmployeeType Type { get; set; }
    }

    enum EmployeeType
    {
        COMMISSIONED, HOURLY, SALARIED
    }

}
