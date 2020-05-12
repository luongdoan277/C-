using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
	class bai2
	{
		static void Main(string[] args) {

			int a, b, c;
			a = 3;
			b = 5;
			c = 8;
			
			if (a > b && a > c)
			{
				Console.WriteLine(a);
			}
			else if (b > a & b > c)
			{
				Console.WriteLine(b);
			}
			else
			{
				Console.WriteLine(c);
			}
		}
	}
}
