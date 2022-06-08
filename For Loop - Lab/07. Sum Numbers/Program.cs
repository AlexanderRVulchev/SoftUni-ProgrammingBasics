//Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
//•	От първия ред на входа се въвежда броят числа n.
//•	От следващите n реда се въвежда по едно цяло число.
//Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += int.Parse(Console.ReadLine());
		}
		Console.WriteLine(sum);
	}
}