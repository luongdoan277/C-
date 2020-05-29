using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
	class Ex1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("please enter your name:");
			String name = Console.ReadLine();
			Console.WriteLine("please enter your address:");
			String address = Console.ReadLine();
			Console.WriteLine("please enter your numberphone:");
			String numberphone = Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine(name + ";" + address + ";" + numberphone) ;
		}
	}
}
