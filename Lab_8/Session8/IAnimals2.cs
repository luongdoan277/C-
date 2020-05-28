using System;
using System.Collections.Generic;
using System.Text;

namespace Session8
{
    interface IAnimals2
    {
        void Drink();
    }
    interface ICarnivorous
    {
        void Habitat();
    }
    interface IReptile : IAnimals2, ICarnivorous
    {
        void Habitat();
    }
    class Crocodile1 : IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drink fresh warter");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in warter Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Fresh");
        }
        //static void Main(string[] args)
        //{
        //    Crocodile1 crocodile = new Crocodile1();
        //    Console.WriteLine(crocodile.GetType().Name);
        //    crocodile.Habitat();
        //    crocodile.Eat();
        //    crocodile.Drink();
        //}
    }
}
