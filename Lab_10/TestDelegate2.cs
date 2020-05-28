using System;
using System.Collections.Generic;
using System.Text;


delegate int Numebrchange(int n);
namespace DelegateAppl
{
    class TestDelegate2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int p)
        {
            num *= p;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        //static void Main(string[] args)
        //{
        //    //create delegate instances
        //    Numberchange nc;
        //    Numberchange nc1 = new Numberchange(AddNum);
        //    Numberchange nc2 = new Numberchange(MultNum);

        //    nc = nc1;
        //    nc += nc2; // nc = nc1 + nc2 voi p = 5

        //    //calling multicast
        //    nc(5);
        //    Console.WriteLine("Value of Num: {0}", getNum());
        //    Console.ReadKey();
        //}
    }
}
