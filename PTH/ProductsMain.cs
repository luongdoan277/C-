using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    class ProductsMain
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[6];

            double Totals = 0;
            //Books
            products[0] = new Books(1, "abcd", 35.000, "Kim Dong");
            products[1] = new Books(2, "abcf", 36.000, "Kim Dong");
            products[2] = new Books(3, "abcg", 37.000, "Kim Dong");

            //MobilePhone
             products[3] = new MobilePhone(4, "xyza", 40.000, "ghl");    
             products[4] = new MobilePhone(5, "xyzs", 41.000, "ghl");
             products[5] = new MobilePhone(6, "xyzc", 42.000, "ghl");

            for (int i = 0; i < 6; i++)
            {
                Totals += products[i].computeTax();
                Console.WriteLine(products[i].ToString());
                Console.WriteLine("computeTax " + (i + 1) + " : " + products[i].computeTax());
            }
            Console.WriteLine("Tong thue " + Totals);
        }
    }
}
