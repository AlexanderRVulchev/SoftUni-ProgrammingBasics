//Да се напише програма, която чете n-на брой цели числа, подадени от потребителя и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 
//•	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
//•	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата. 
//Разликата се изчислява по абсолютна стойност. 

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int even = 0;
		int odd = 0;
		for (int i = 1; i <= n; i++)
		{
			if (i % 2 == 0) even += int.Parse(Console.ReadLine());
			else odd += int.Parse(Console.ReadLine());
		}
		if (even == odd) Console.WriteLine("Yes\nSum = {0}", even);
		else Console.WriteLine("No\nDiff = {0}", Math.Abs(even - odd));

	}
}