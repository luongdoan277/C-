using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2.45, "red", 23);
            Console.WriteLine("Circle before change: " + c1.ToString());

            c1.PColor = "green";
            Console.WriteLine(c1.PWeight + "\n");
            c1.PWeight = 2.7;

            Console.WriteLine("Circle after change: " + c1.ToString());
            Console.ReadLine();
        }
    }
}
