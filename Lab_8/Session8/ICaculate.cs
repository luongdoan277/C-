using System;
using System.Collections.Generic;
using System.Text;

namespace Session8
{
    interface ICaculate
    {
        double Area();
    }
    class Rectangles : ICaculate
    {
        float _lenght;
        float _breadth;
        public Rectangles(float valOne,float valTwo)
        {
            _lenght = valOne;
            _breadth = valTwo;
        }
        public double Area()
        {
            return _lenght * _breadth;
        }
        //static void Main(string[] args)
        //{
        //    Rectangles objRectangle = new Rectangles(3,5);
        //    if (objRectangle is ICaculate)
        //    {
        //        Console.WriteLine("Area of rectangle: {0:F2}", objRectangle.Area());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Interface method not implemented");
        //    }
        //}
    }

}
