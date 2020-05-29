using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    class Books : Products
    {
        public Books(int id, string name, double price, string Producer) :base( id,  name,  price,  Producer){}
        public override double computeTax()
        {
            return Price * 8 * 1 / 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
