using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Animal3
    {
        public void Eat() {
            Console.WriteLine("Father");
        }
    }
    class Dog2 : Animal3
    {
        public new void Eats()
        {
            Console.WriteLine("Chidren!");
        }
        //public static void Main(string[] args)
        //{
        //    Dog2 dog = new Dog2();
        //    dog.Eat();
               
        //}
    }
}
