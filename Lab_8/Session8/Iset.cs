using System;
using System.Collections.Generic;
using System.Text;

namespace Session8
{
    interface Iset
    {
        void AcceptDetails(int valOne, string valTwo);
    }
    interface IGet
    {
        void Display();
    }
    class Employee : Iset
    {
        int _empID;
        string _empName;
        public void AcceptDetails(int valOne,string valTwo)
        {
            _empID = valOne;
            _empName = valTwo;
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.AcceptDetails(10, "jack");
            IGet objGet = objEmployee as IGet;
            if(objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
        }
    }
}
