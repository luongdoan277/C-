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
    }
}
