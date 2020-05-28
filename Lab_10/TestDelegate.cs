using System;

delegate int Numberchange(int n);
namespace AP_16
{
    class TestDelegate
    {
        static int num = 10;
        
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        //static void Main(string[] args)
        //{
        //    Numberchange nc;
        //    Numberchange nc1 = new Numberchange(AddNum);
        //    Numberchange nc2 = new Numberchange(MultNum);
        //    nc1(1);
        //    Console.WriteLine("Value of Num:{0}", getNum());
        //    nc2(2);
        //    Console.WriteLine("Value of Num:{0}", getNum());
        //}
    }
}
