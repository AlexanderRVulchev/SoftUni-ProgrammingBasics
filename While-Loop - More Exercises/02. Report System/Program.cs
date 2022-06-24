//На благотворително събитие плащанията за закупените продукти винаги се редуват:
//плащане в брой и плащане с карта. Установени са следните правила за заплащане:
//•	Ако продуктът надвишава 100лв., за него не може да се плати в брой
//•	Ако продуктът е на цена под 10лв., за него не може да се плати с кредитна карта
//Програмата приключва или след като получим команда "End" или след като средствата бъдат събрани.
//Вход
//От конзолата се четат:
//•	Сумата, която се очаква да бъде събрана от продажбите - цяло число в интервала [1 ... 10000]
//На всеки следващ ред, до получаване на командата "End" или докато не се съберат нужните средства:
//цените на предметите, които ще бъдат закупени - цяло число в интервала [1 ... 500]
//Изход
//На конзолата да се отпечата:
//•	При успешна транзакция: "Product sold!"
//•	При неуспешна транзакция: "Error in transaction!"
//•	Ако сумата на всички закупени продукти надвиши или достигне очакваната сума,
//програмата трябва да приключи и на конзолата да се изпишат два реда:
//o "Average CS: {средно плащане в кеш на човек}"
//o "Average CC: {средно плащане с карта на човек}"
//              Плащанията трябва да бъдат форматирани до втората цифра след десетичния знак.
//•	При получаване на команда "End", да се изпише един ред:
//o "Failed to collect required money for charity."

using System;

public class Program
{
	public static void Main()
	{
		int target = int.Parse(Console.ReadLine());
		string input = Console.ReadLine();
		int cash = 0;
		int card = 0;
		int counter = 1;
		int cashCount = 0;
		int cardCount = 0;

		while (input != "End")
		{
			int num = int.Parse(input);
			if (counter % 2 == 0) // card transaction
			{
				if (num < 10) Console.WriteLine("Error in transaction!");
				else { Console.WriteLine("Product sold!"); card += num; cardCount++; }
			}
			else  // cash transaction
			{
				if (num > 100) Console.WriteLine("Error in transaction!");
				else { Console.WriteLine("Product sold!"); cash += num; cashCount++; }
			}
			if (cash + card >= target) // check for reached target
			{
				Console.WriteLine("Average CS: {0:f2}", (double)cash / (double)cashCount);
				Console.WriteLine("Average CC: {0:f2}", (double)card / (double)cardCount);
				return;
			}
			counter++;
			input = Console.ReadLine();
		}
		Console.WriteLine("Failed to collect required money for charity.");
	}
}