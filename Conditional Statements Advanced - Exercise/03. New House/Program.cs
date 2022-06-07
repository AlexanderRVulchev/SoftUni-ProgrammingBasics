//Марин и Нели си купуват къща не далеч от София.
//Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва,
//да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен.
//Различните цветя са с различни цени. 
//цвете	Роза	Далия	Лале	Нарцис	Гладиола
//Цена на брой в лева	5	3.80	2.80	3	2.50
//Съществуват следните отстъпки:
//•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
//•	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
//•	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
//•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
//•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
//От конзолата се четат 3 реда:
//•	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
//•	Брой цветя - цяло число в интервала [10…1000]
//•	Бюджет - цяло число в интервала [50…2500]
//Да се отпечата на конзолата на един ред:
//•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
//•	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
//Сумата да бъде форматирана до втория знак след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		string flower = Console.ReadLine();
		int amount = int.Parse(Console.ReadLine());
		int budget = int.Parse(Console.ReadLine());
		double total = 0;

		switch (flower)
		{
			case "Roses":
				total = amount * 5.00;
				if (amount > 80) total -= 0.1 * total;
				break;
			case "Dahlias":
				total = amount * 3.80;
				if (amount > 90) total -= 0.15 * total;
				break;
			case "Tulips":
				total = amount * 2.80;
				if (amount > 80) total -= 0.15 * total;
				break;
			case "Narcissus":
				total = amount * 3.00;
				if (amount < 120) total += 0.15 * total;
				break;
			case "Gladiolus":
				total = amount * 2.50;
				if (amount < 80) total += 0.2 * total;
				break;
		}

		if (budget >= total) Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", amount, flower, budget - total);
		else Console.WriteLine("Not enough money, you need {0:f2} leva more.", total - budget);
	}
}