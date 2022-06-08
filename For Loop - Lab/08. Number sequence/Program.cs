//Напишете програма, която чете n на брой цели числа. Принтирайте най-голямото и най-малкото число сред въведените.

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int min = int.MaxValue;
		int max = int.MinValue;
		for (int i = 1; i <= n; i++)
		{
			int newNumber = int.Parse(Console.ReadLine());
			if (newNumber < min) min = newNumber;
			if (newNumber > max) max = newNumber;
		}
		Console.WriteLine("Max number: {0}", max);
		Console.WriteLine("Min number: {0}", min);
	}
}