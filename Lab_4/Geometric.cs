using System;

namespace GeometicObjectDemo
{
   abstract class Geometric
    {
        protected string color;
        protected double weight;
        //Default Constructor
        protected Geometric()
        {
            color = "white";
            weight = 1.0;
        }
        protected Geometric(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public string PColor
        {
            get { return color; }
            set { color = value; }
        }

        public double PWeight
        {
            get { return weight; }
            set { weight = value; }
        }

        //Abtract method
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}
