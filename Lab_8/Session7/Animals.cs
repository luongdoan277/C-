using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Animals
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animals does something");
        }
    }
    class Cat3 : Animals
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
        //static void Main(string[] args)
        //{
        //    Cat3 cat = new Cat3();
        //    cat.Eat();
        //    cat.DoSomething();
        //}
    }
}
