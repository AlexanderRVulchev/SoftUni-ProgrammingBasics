//Напишете софтуер, който да пресмята сметката на клиент, закупил определен брой от дадена напитка от кафемашина.
//	Без захар	Нормално	Допълнително захар
//Еспресо	0.90 лв./бр.	1 лв. /бр.	1.20 лв. /бр.
//Капучино	1.00 лв. /бр.	1.20 лв. /бр.	1.60 лв. /бр.
//Чай	0.50 лв. /бр.	0.60 лв. /бр.	0.70 лв. /бр.
//Трябва да имате предвид следните отстъпки:
//•	При избрана напитка без захар има 35% отстъпка.
//•	При избрана напитка "Espresso" и закупени поне 5 броя, има 25% отстъпка.
//•	При сума надвишава 15 лева, 20% отстъпка от крайната цена,
//Отстъпките се прилагат в реда на тяхното описване.
//Вход
//Входът се чете от конзолата и се състои от три реда:
//•	Първи ред - напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
//•	Втори ред - захар - текст  с възможности "Without", "Normal" или "Extra"
//•	Трети ред - брой напитки - цяло число в интервала [1… 50]
//Изход
//На конзолата трябва да се отпечата един ред:
//"You bought {брой напитки} cups of {напитка} for {крайна цена} lv."
//Цената да бъде форматирана до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		string drink = Console.ReadLine();
		string sugar = Console.ReadLine();
		int quantity = int.Parse(Console.ReadLine());
		double price = 0;
		double total = 0;

		switch (sugar)
		{
			case "Without":
				if (drink == "Espresso") price = 0.90;
				else if (drink == "Cappuccino") price = 1.00;
				else price = 0.50;
				price *= 0.65;
				break;
			case "Normal":
				if (drink == "Espresso") price = 1.00;
				else if (drink == "Cappuccino") price = 1.20;
				else price = 0.60;
				break;
			case "Extra":
				if (drink == "Espresso") price = 1.20;
				else if (drink == "Cappuccino") price = 1.60;
				else price = 0.70;
				break;
		}
		if (drink == "Espresso" && quantity >= 5) price *= 0.75;
		total = price * quantity;
		if (total > 15.00) total *= 0.8;

		Console.WriteLine("You bought {0} cups of {1} for {2:f2} lv.", quantity, drink, total);
	}
}