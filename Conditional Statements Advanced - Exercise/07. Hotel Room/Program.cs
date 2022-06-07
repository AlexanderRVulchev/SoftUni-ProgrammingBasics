//Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за целия престой за студио и апартамент.
//Цените зависят от месеца на престоя:
//Май и октомври	Юни и септември	Юли и август
//Студио – 50 лв./нощувка	Студио – 75.20 лв./нощувка	Студио – 76 лв./нощувка
//Апартамент – 65 лв./нощувка	Апартамент – 68.70 лв./нощувка	Апартамент – 77 лв./нощувка
//Предлагат се и следните отстъпки:
//•	За студио, при повече от 7 нощувки през май и октомври : 5 % намаление.
//•	За студио, при повече от 14 нощувки през май и октомври : 30 % намаление.
//•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
//•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
//Вход
//Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
//•	На първия ред е месецът – May, June, July, August, September или October
//•	На втория ред е броят на нощувките – цяло число в интервала [0 ... 200]
//Изход
//Да се отпечатат на конзолата 2 реда:
//•	На първия ред: “Apartment: { цена за целият престой}
//lv.”
//•	На втория ред: “Studio: { цена за целият престой}
//lv.“
//Цената за целия престой форматирана с точност до два знака след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		string month = Console.ReadLine();
		int nights = int.Parse(Console.ReadLine());

		double studio = 0;
		double apartment = 0;

		switch (month)
		{
			case "May":
			case "October":
				{
					studio = nights * 50.00;
					apartment = nights * 65.00;
					if (nights > 14) studio -= studio * 0.3;
					else if (nights > 7) studio -= studio * 0.05;
					break;
				}
			case "June":
			case "September":
				{
					studio = nights * 75.20;
					apartment = nights * 68.70;
					if (nights > 14) studio -= studio * 0.2;
					break;
				}
			case "July":
			case "August":
				{
					studio = nights * 76.00;
					apartment = nights * 77.00;
					break;
				}
		}
		if (nights > 14) apartment -= apartment * 0.1;

		Console.WriteLine("Apartment: {0:f2} lv.", apartment);
		Console.WriteLine("Studio: {0:f2} lv.", studio);
	}
}