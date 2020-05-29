using System;

namespace Products
{
    abstract  class Products
    {
        protected int Id;
        protected string Name;
        protected double Price;
        protected string Producer;
        
        

        public Products(int id,string name,double price,string Producer)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Producer = Producer;
            
        }

        public abstract double computeTax();

        public override string ToString()
        {
            return "id: " + this.Id + ", name: " + this.Name + ", price: " + this.Price + ", producer:  " + this.Producer;
        }
    }
}
