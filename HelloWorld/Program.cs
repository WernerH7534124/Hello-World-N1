using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! - What is your name?");
			
			string OPName;
			
			OPName = Console.ReadLine();

			Console.WriteLine("Nice to meet you " + OPName + "!");

		Console.Read();

		}
	}
}
