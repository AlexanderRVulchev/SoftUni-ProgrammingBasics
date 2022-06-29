//Магазин за компютърни игри ви наема за да направите статистика на процента продажби на игрите от последния месец,
//като изчислите по колко процента от общите продажби са за някоя от игрите.
//Процентите трябва да бъдат разделени на четири части, три заглавия на игри и всички останали :
//•	Hearthstone
//•	Fornite
//•	Overwatch
//•	Others
//Вход
//От конзолата се четат:
//•	Брой продадени игри- n - цяло положително число в интервала [1… 100]
//За следващите n реда се чете по един ред:
//o Име на игра - текст
//Изход
//На конзолата да се изпишат четири реда:
//	"Hearthstone - {процент продажби на Hearthstone}%"
//	"Fornite - {процент продажби на Fornite}%"
//	"Overwatch - {процент продажби на Overwatch}%"
//	"Others - {процент продажби на всички останали игри}%"
//Резултатът да бъде закръглен до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int hearthstone = 0;
		int fornite = 0;
		int overwatch = 0;
		int others = 0;

		for (int i = 1; i <= n; i++)
		{
			string input = Console.ReadLine();
			switch (input)
			{
				case "Hearthstone": hearthstone++; break;
				case "Fornite": fornite++; break;
				case "Overwatch": overwatch++; break;
				default: others++; break;
			}
		}
		Console.WriteLine("Hearthstone - {0:f2}%", hearthstone * 100.0 / n);
		Console.WriteLine("Fornite - {0:f2}%", fornite * 100.0 / n);
		Console.WriteLine("Overwatch - {0:f2}%", overwatch * 100.0 / n);
		Console.WriteLine("Others - {0:f2}%", others * 100.0 / n);
	}
}