//Напишете програма, която проверява дали точка {x, y} се намира върху някоя от страните на правоъгълник {x1, y1} – { x2, y2}.
//Входните данни се четат от конзолата и се състоят от 6 реда въведени от потребителя:
//десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2).
//Да се отпечата "Border" (точката лежи на някоя от страните) или "Inside / Outside"(в противен случай).

using System;

public class Program
{
	public static void Main()
	{
		double x1 = double.Parse(Console.ReadLine());
		double y1 = double.Parse(Console.ReadLine());
		double x2 = double.Parse(Console.ReadLine());
		double y2 = double.Parse(Console.ReadLine());
		double x = double.Parse(Console.ReadLine());
		double y = double.Parse(Console.ReadLine());
		bool top = x >= x1 && x <= x2 && y == y1;
		bool bottom = x >= x1 && x <= x2 && y == y2;
		bool left = x == x1 && y >= y1 && y <= y2;
		bool right = x == x2 && y >= y1 && y <= y2;
		bool onBorder = top || bottom || left || right;

		if (onBorder) Console.WriteLine("Border");
		else Console.WriteLine("Inside / Outside");
	}
}