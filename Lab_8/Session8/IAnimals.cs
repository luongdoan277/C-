using System;
using System.Collections.Generic;
using System.Text;

namespace Session8
{
    interface IAnimals
    {
        void Habitat();
    }
    class Dog : IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
        //static void Main(string[] args)
        //{
        //    Dog objDog = new Dog();
        //    Console.WriteLine(objDog.GetType().Name);
        //    objDog.Habitat();
        //}
    }
}
