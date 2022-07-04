//С наближаването на Великденските празници, цех за боядисване на яйца, започва да боядисва различни размери яйца, които след това продава на партиди.
//В таблицата са показани размерите на яйцата, различните бои и каква е цената за продажба на една партида яйца, зависеща от размерите и цвета боя. 
//	Червено (Red)	Зелено(Green)  Жълто(Yellow)
//Големи(Large)  16 лв.  12 лв.  9 лв.
//Средни(Medium) 13 лв.  9 лв.   7 лв.
//Малки(Small)   9 лв.   8 лв.   5 лв.
//Напишете програма, която изчислява какви ще са приходите на цеха от продажбите, като знаете размера на яйцата и техният цвят.
//С 35% от крайната цена ще бъдат покрити производствени разходи.
//Вход
//Входът се чете от конзолата и се състои от три реда:
//•	Първи ред – размер на яйцата – текст с възможности "Large", "Medium" или "Small"
//•	Втори ред – цвят на яйцата – текст  с възможности "Red", "Green" или "Yellow"
//•	Трети ред – брой партиди – цяло число в интервала [1… 350]
//Изход
//На конзолата трябва да се отпечата един ред:
//"{крайната цена} leva."
//Резултатът да се форматира до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		string size = Console.ReadLine();
		string color = Console.ReadLine();
		int count = int.Parse(Console.ReadLine());
		int cost = 0;
		double total = 0;

		switch (color)
		{
			case "Red":
				switch (size)
				{
					case "Large": cost = 16; break;
					case "Medium": cost = 13; break;
					case "Small": cost = 9; break;
				}
				break;
			case "Green":
				switch (size)
				{
					case "Large": cost = 12; break;
					case "Medium": cost = 9; break;
					case "Small": cost = 8; break;
				}
				break;
			case "Yellow":
				switch (size)
				{
					case "Large": cost = 9; break;
					case "Medium": cost = 7; break;
					case "Small": cost = 5; break;
				}
				break;
		}
		total = count * cost;
		total -= total * 0.35;
		Console.WriteLine("{0:f2} leva.", total);
	}
}