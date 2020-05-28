using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Animal4
    {
        public Animal4()
        {
            Console.WriteLine("Animal constructor without parameters");
        }

        public Animal4(string name)
        {
            Console.WriteLine("Animal constructor with out parameter");
        }
    }
    class Cannie : Animal4
    {
        //base() takes a string value called "Lion"
        public Cannie() : base("Lion")
        {
            Console.WriteLine("Derived Cannie");
        }
    }
    class Details
    {
        //static void Main(string[] args)
        //{
        //    Cannie objCannie = new Cannie();
        //}
    }
}
