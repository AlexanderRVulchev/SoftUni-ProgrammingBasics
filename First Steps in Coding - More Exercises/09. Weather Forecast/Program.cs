//Напишете програма, която познава дали е топло или студено навън.
//От конзолата се чете един ред – текст, който подсказва какво е времето.
//При въвеждане на "sunny" трябва да се отпечата "It's warm outside!".
//Във всички останали случаи трябва да се отпечата "It's cold outside!". 

using System;

public class Program
{
	public static void Main()
	{
		string input = Console.ReadLine();
		if (input == "sunny") Console.WriteLine("It's warm outside!");
		else Console.WriteLine("It's cold outside!");
	}
}