using System;
using System.Collections.Generic;
using System.Text;

namespace Session13
{
    class Employee
    {
        string empName;
        int empID;

        public Employee(string name, int id)
        {
            this.empName = name;
            this.empID = id;
        }
        public string Name
        {
            get
            {
                return empName;
            }
        }
        public int Id
        {
            get
            {
                return empID;
            }
        }
    }
    class GenericList<T> where T : Employee
    {
        T[] name = new T[3];
        int count = 0;
        public void Add(T val)
        {
            name[count] = val;
            count++;
        }
        public void Display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(name[i].Name + " , " + name[i].Id);
            }
        }
    }
    class ContrainDemo
    {
        //static void Main(string[] args)
        //{
        //    GenericList<Employee> objList = new GenericList<Employee>();
        //    objList.Add(new Employee("John", 100));
        //    objList.Add(new Employee("James", 200));
        //    objList.Add(new Employee("Patrich", 300));
        //    objList.Display();
        //}
        
    }
}
