//Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя.
//Налични са следните видове помещения, със следните цени за престой:
//	"room for one person" – 18.00 лв за нощувка
//	"apartment" – 25.00 лв за нощувка 
//	"president apartment" – 35.00 лв за нощувка
//Според броят на дните, в които ще остане в хотела (пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той може да ползва различно намаление. 
//Намаленията са както следва:
//вид помещение	по-малко от 10 дни	между 10 и 15 дни	повече от 15 дни
//room for one person	не ползва намаление	не ползва намаление	не ползва намаление
//apartment	30% от крайната цена	35% от крайната цена	50% от крайната цена
//president apartment	10% от крайната цена	15% от крайната цена	20% от крайната цена
//След престоя, оценката на Атанас за услугите на хотела може да е позитивна (positive) или негативна(negative).
//Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея. Ако оценката му е негативна приспада от цената 10%.

using System;

public class Program
{
	public static void Main()
	{
		int days = int.Parse(Console.ReadLine());
		string type = Console.ReadLine();
		string grade = Console.ReadLine();
		double total = 0;
		days--;
		switch (type)
		{
			case "room for one person":
				{
					total = days * 18.00;
					break;
				}
			case "apartment":
				{
					total = days * 25.00;
					if (days > 15) total -= 0.5 * total;
					else if (days >= 10) total -= 0.35 * total;
					else total -= 0.3 * total;
					break;
				}
			case "president apartment":
				{
					total = days * 35.00;
					if (days > 15) total -= 0.2 * total;
					else if (days >= 10) total -= 0.15 * total;
					else total -= 0.1 * total;
					break;
				}
		}
		if (grade == "positive") total += 0.25 * total;
		else total -= 0.1 * total;
		Console.WriteLine("{0:f2}", total);
	}
}