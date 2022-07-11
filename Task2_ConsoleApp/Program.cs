using System;

namespace Task2_ConsoleApp
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello Academy Oslo - again!");
			Hamster jojo = new("jojo",true,HamsterSpecies.WinterWhite);
			GodCat cat = new ();
			cat.EatHAmster(jojo);
		}
	}
}
