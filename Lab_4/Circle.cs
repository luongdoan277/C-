using GeometicObjectDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjectDemo
{
    class Circle : Geometric
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color,double weight) : base(color, weight)
        {
            this.radius = radius;
        }

        public override String ToString()
        {
            return "Circle has: radius is " + radius 
                + ", color is " + PColor +
                ", weight is " + PWeight;
        }
        public override double findArea()
        {
            return Math.PI * radius * radius;
        }
        public override double findPerimeter()
        {
            return  2 * Math.PI * radius;
        }
    }
}
