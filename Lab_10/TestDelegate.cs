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
    }
}
