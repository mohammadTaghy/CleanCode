using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_Functions_Clean
{

    public class EmployeeFactoryImpl : EmployeeFactory
    {
        public Employee MakeEmployee(EmployeeRecord employeeRecord)
        {
            switch (employeeRecord.Type)
            {
                case EmployeeType.COMMISSIONED:
                    return new CommissionedEmployee(employeeRecord);
                case EmployeeType.HOURLY:
                    return new HourlyEmployee(employeeRecord);
                case EmployeeType.SALARIED:
                    return new SalariedEmploye(employeeRecord);
                default:
                    throw new Exception("");
            }

        }
        
    }
    public abstract class Employee
    {
        public abstract bool isPayday();
        public abstract Money calculatePay();
        public abstract void deliverPay(Money pay);
    }
    public interface EmployeeFactory
    {
        public Employee MakeEmployee(EmployeeRecord employeeRecord);
    }
    class CommissionedEmployee : Employee
    {
        public CommissionedEmployee(EmployeeRecord employeeRecord)
        {

        }
        public override Money calculatePay()
        {
            throw new NotImplementedException();
        }

        public override void deliverPay(Money pay)
        {
            throw new NotImplementedException();
        }

        public override bool isPayday()
        {
            throw new NotImplementedException();
        }
    }
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(EmployeeRecord employeeRecord)
        {

        }
        public override Money calculatePay()
        {
            throw new NotImplementedException();
        }

        public override void deliverPay(Money pay)
        {
            throw new NotImplementedException();
        }

        public override bool isPayday()
        {
            throw new NotImplementedException();
        }
    }
    class SalariedEmploye : Employee
    {
        public SalariedEmploye(EmployeeRecord employeeRecord)
        {

        }
        public override Money calculatePay()
        {
            throw new NotImplementedException();
        }

        public override void deliverPay(Money pay)
        {
            throw new NotImplementedException();
        }

        public override bool isPayday()
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeRecord
    {
        public EmployeeType Type { get; set; }
    }
    public class Money
    {

    }
    public enum EmployeeType
    {
        COMMISSIONED, HOURLY, SALARIED
    }


}

