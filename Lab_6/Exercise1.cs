using System;
using System.Security.Cryptography.X509Certificates;
using Customer;
using Order;

namespace Customer
{
    class NameCustomer
    {
        public string name;
        public void getName()
        {
            name = Console.ReadLine();
        }
    }
}

namespace Order
{
    class grocery
    {
        public void getGrocery()
        {
            Console.WriteLine("Enter n :" + "\n");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("'Gao' da dc them vao gio hang");
                    break;
                case 2:
                    Console.WriteLine("'Ngo' da dc them vao gio hang");
                    break;
                case 3:
                    Console.WriteLine("'Khoai' da dc them vao gio hang");
                    break;
                case 4:
                    Console.WriteLine("'San' da dc them vao gio hang");
                    break;
                case 5:
                    Console.WriteLine("'Oliu' da dc them vao gio hang");
                    break;
                    if (x == 6)
                    {
                        break;
                    }
            }
            
        }
    }

    class bakeryProducts
    {
        public void getBakery()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("'Banh mi' da dc them vao gio hang");
                    break;
                case 2:
                    Console.WriteLine("'Banh mi' da dc them vao gio hang");
                    break;
                case 3:
                    Console.WriteLine("'Banh gao' da dc them vao gio hang");
                    break;
                case 4:
                    Console.WriteLine("'Banh quy' da dc them vao gio hang");
                    break;
                case 5:
                    Console.WriteLine("'Banh quay' da dc them vao gio hang");
                    break;
                    if (x == 6)
                    {
                        break;
                    }
            }
        }
    }
}


namespace Exercise1
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach san pham: ");
            Console.WriteLine("1. Glocery");
            Console.WriteLine("2. Bakery");

            Console.WriteLine("Enter x : " + "\n");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine(".1 - Gao");
                    Console.WriteLine(".2 - Ngo");
                    Console.WriteLine(".3 - Khoai");
                    Console.WriteLine(".4 - San");
                    Console.WriteLine(".5 - Oliu");
                    Console.WriteLine(".6 - Thoat");
                    
                    grocery grocery = new grocery();
                    grocery.getGrocery();
                    break;
                case 2:
                    Console.WriteLine(".1 - Banh mi");
                    Console.WriteLine(".2 - Banh Kem");
                    Console.WriteLine(".3 - Banh gao");
                    Console.WriteLine(".4 - Banh quy");
                    Console.WriteLine(".5 - Banh quay");
                    Console.WriteLine(".6 - Thoat");

                    bakeryProducts bakery = new bakeryProducts();
                    bakery.getBakery();
                    break;
            }
        }
    }
}
