//Напишете програма, която чете число n, въведено от потребителя и отпечатва числата от 1 до n през 3.

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		for (int i = 1; i <= n; i += 3)
		{
			Console.WriteLine(i);
		}
	}
}