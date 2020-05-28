using System;

namespace Lab08
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animals eats something");
        }
    }
    class Marmal : Animal
    {
        public void Future()
        {
            Console.WriteLine("Name is give birth to young ones");
        }
    }
    class Dog : Marmal
    {
        public void Noice()
        {
            Console.WriteLine("Dog Barks.");
        }
        /*static void Main()
        {
            Dog dog = new Dog();
            dog.Noice();
            dog.Future();
            dog.Eat();
        }*/
    }
}
