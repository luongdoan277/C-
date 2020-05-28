using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Employee
    {
        int _empId = 1;
        string _empName = "Jame Anderson";
        int _age = 25;
        public void Display()
        {
            Console.WriteLine("Employee ID " + _empId);
            Console.WriteLine("EmployyName " + _empName);
            Console.WriteLine("EMployee Age " + _age);
        }
    }
    class Department : Employee
    {
        int _deptid = 501;
        string _depName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine();
            Console.WriteLine("DepartmentID " + _deptid);
            Console.WriteLine("Department Name " + _depName);
        }
        //static void Main(string[] args)
        //{
        //    Department ObjDepartment = new Department();
        //    ObjDepartment.Display();
        //}
    }
}
