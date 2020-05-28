using System;
using System.Collections.Generic;
using System.Text;

namespace Session13
{
    class Generals<T,U>
    {
        T valOne;
        U valTwo;
        public void AcceptValues(T item)
        {
            valOne = item;
        }
        public void AcceptValues(U item)
        {
            valTwo = item;
        }
        public void Display()
        {
            Console.WriteLine(valOne + "\t" + valTwo);
        }
    }
    class MethodOverload
    {
        //static void Main(string[] args)
        //{
        //    Generals<int, string> objGenOne = new Generals<int, string>();
        //    objGenOne.AcceptValues(10);
        //    objGenOne.AcceptValues("Smith");
        //    Console.WriteLine("ID\tName\tDesignation\tSalary");
        //    objGenOne.Display();
        //    Generals<string, float> objGenTwo = new Generals<string, float>();
        //    objGenTwo.AcceptValues("Mechanic");
        //    objGenTwo.AcceptValues(2500);
        //    Console.Write("\t");
        //    objGenTwo.Display();
        //    Console.WriteLine();
        //}
    }

}
