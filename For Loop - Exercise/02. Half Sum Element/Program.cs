//Да се напише програма, която чете n-на брой цели числа, въведени от потребителя,
//и проверява дали сред тях съществува число, което е равно на сумата на всички останали. 
//•	Ако има такъв елемент печата "Yes" и на нов ред "Sum = "  + неговата стойност
//•	Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност)

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int max = int.MinValue;
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			int newNumber = int.Parse(Console.ReadLine());
			sum += newNumber;
			max = Math.Max(newNumber, max);
		}
		if (max == sum - max) Console.WriteLine("Yes\nSum = {0}", max);
		else Console.WriteLine("No\nDiff = {0}", Math.Abs(max - (sum - max)));
	}
}