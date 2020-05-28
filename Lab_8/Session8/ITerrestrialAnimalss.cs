using System;
using System.Collections.Generic;
using System.Text;

namespace Session8
{
    interface ITerrestrialAnimalss
    {
        string Eat();
    }
    interface IMariAnimal
    {
        string Eat();
    }
    class Croodile : ITerrestrialAnimalss,IMariAnimal
    {
        string ITerrestrialAnimalss.Eat()
        {
            string terCroc = "Croodile eat fishs and marrine animals";
            return terCroc;
        }
        string IMariAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            ITerrestrialAnimalss objTe;
            objTe = this;
            return objTe.Eat();
        }
        public string EatMarine()
        {
            IMariAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }
        //public static void Main(string[] args)
        //{
        //    Croodile objCrocodile = new Croodile();
        //    string terCroc = objCrocodile.EatTerrestrial();
        //    Console.WriteLine(terCroc);
        //    string marCroc = objCrocodile.EatMarine();
        //    Console.WriteLine(marCroc);
        //}
    }


}
