using System;
using System.Collections.Generic;
using System.Text;

namespace Session13
{
    class SwapNumbers
    {
        static void Swap<T>(ref T valOne,ref T valTwo)
        {
            T temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
        //static void Main(string[] args)
        //{
        //    int numOne = 23;
        //    int numTwo = 50;
        //    Console.WriteLine("values before swapping: " + numOne + " & " + numTwo );
        //    Swap<int>(ref numOne, ref numTwo);
        //    Console.WriteLine("values before swapping: " + numOne + " & " + numTwo);
        //}
    }
}
