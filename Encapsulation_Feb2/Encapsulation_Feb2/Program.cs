//Encapsulation Program
using System;  

namespace Encapsulation_Feb2
{
    class Employee
    {
        private string employeeName;
        private int employeeId;
        public string GetEmployeeName()
        {
            return employeeName; 
        }
        public void SetEmployeeName(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }
        public void SetEmployeeid(int employeeId)
        {
            this.employeeId = employeeId;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetEmployeeName("Sunil Yaswanth");
            employee.SetEmployeeid(123);
            Console.WriteLine("Employee Name is: "+employee.GetEmployeeName());
            Console.WriteLine("Employee Id is: "+employee.GetEmployeeId()); 
        }
    }
}
