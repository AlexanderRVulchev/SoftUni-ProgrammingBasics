//Напишете програма, която при въведени градуси (реално число) принтира какво е времето, като имате предвид следната таблица:
//Градуси Време
//26.00 - 35.00	Hot
//20.1 - 25.9	Warm
//15.00 - 20.00	Mild
//12.00 - 14.9	Cool
//5.00 - 11.9	Cold
//Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown".

using System;

public class Program
{
	public static void Main()
	{
		double input = double.Parse(Console.ReadLine());
		if (input < 5 || input > 35) Console.WriteLine("unknown");
		else if (input >= 5 && input < 12) Console.WriteLine("Cold");
		else if (input < 15) Console.WriteLine("Cool");
		else if (input <= 20) Console.WriteLine("Mild");
		else if (input < 26) Console.WriteLine("Warm");
		else if (input <= 35) Console.WriteLine("Hot");
	}
}