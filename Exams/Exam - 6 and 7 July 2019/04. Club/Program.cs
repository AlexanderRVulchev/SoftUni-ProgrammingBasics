//Времето се затопля и клубовете пускат обещаващи промоции.
//Напише програма, която да изчислява приходите на един клуб за вечерта и дали е достигната желаната печалба,
//като знаете следните условия: цената на един коктейл е дължината неговото име.
//Ако цената на една поръчка е нечетно число, има 25% отстъпка от цената на поръчката. 
//Вход
//От конзолата се четат:
//•	На първия ред – желаната печалба на клуба - реално число в интервала [1.00... 15000.00]
//Поредица от два реда до получаване на командата "Party!" или до достигане на желаната печалба:
//o Име на коктейла – текст
//o	Брой на коктейлите за поръчката – цяло число в интервала [1… 50]
//Изход
//На конзолата първо да се отпечата един ред:
//•	При получена команда "Party!":
// "We need {недостигаща сума} leva more."
//•	При достигане на желаната печалба:
//	"Target acquired."
//След това да се отпечата:
//	"Club income - {приходи от клуба} leva."
//Парите да бъдат форматирани до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		double profit = double.Parse(Console.ReadLine());
		string input = Console.ReadLine();
		double total = 0;

		while (input != "Party!")
		{
			int quantity = int.Parse(Console.ReadLine());
			int price = input.Length;
			double cost = quantity * price;
			if ((quantity * price) % 2 == 1) cost *= 0.75;
			total += cost;
			if (total >= profit) break;
			input = Console.ReadLine();
		}

		if (total >= profit) Console.WriteLine("Target acquired.");
		else Console.WriteLine("We need {0:f2} leva more.", profit - total);
		Console.WriteLine("Club income - {0:f2} leva.", total);
	}
}