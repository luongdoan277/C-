using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    class Animal2
    {
        protected string Food;
        protected string activity;
    }
    class Cat : Animal2
    {
        /*static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mousre";
            objCat.activity = "Larearound";
            Console.WriteLine("The cat love to eats " + objCat.Food + ".");
            Console.WriteLine("The cat love to " + objCat.activity + ".");
        }*/
    }
    class Human : Cat
    {
        /* static void Main(string[] args)
         {
             Human human = new Human();
             human.activity();
             human.Food();
         }*/
    }
}
