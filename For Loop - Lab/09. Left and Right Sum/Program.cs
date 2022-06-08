//Да се напише програма, която чете 2*n-на брой цели числа, подадени от потребителя, и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите n числа (дясна сума).
//При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
//Разликата се изчислява като положително число (по абсолютна стойност). 

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int left = 0;
		int right = 0;
		for (int i = 1; i <= n; i++) left += int.Parse(Console.ReadLine());
		for (int i = 1; i <= n; i++) right += int.Parse(Console.ReadLine());
		if (left == right) Console.WriteLine("Yes, sum = {0}", left);
		else Console.WriteLine("No, diff = {0}", Math.Abs(left - right));
	}
}