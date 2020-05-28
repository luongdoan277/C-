﻿using System;

namespace ExcepHanding1
{
    class ExcepHanding1
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];
            //nhap mang
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a [{0}]", + i+ 1 );
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }catch(FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong dc nhap ki tu nao cho mang so");

            }catch(OverflowException ex)
            {
                Console.WriteLine("Khong dc nhap gia tri ngoai mien 0-255");
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            //in ra mang
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" {0} ", a[i]);
            }
        }
    }
}
