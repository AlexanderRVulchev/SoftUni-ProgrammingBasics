//Семейство Иванови планират семейната си почивка.
//Вашата задача е да напишете програма, която да изчислява дали предвидения от тях бюджет ще им стигне,
//като знаете колко нощувки са планирали, каква е цената за нощувка и колко процента от бюджета са предвидили за допълнителни разходи.
//Трябва да се има предвид, че ако броят на нощувките е по-голям от 7, цената за нощувка се намаля с 5%.
//Вход
//От конзолата се четат 4 реда:
//•	Бюджетът, с който разполагат – реално число в интервала [1.00 … 10000.00]
//•	Брой нощувки – цяло число в интервала [0 … 1000]
//•	Цена за нощувка – реално число в интервала [1.00 … 500.00]
//•	Процент за допълнителни разходи – цяло число в интервала [0 … 100]
//Изход
//Отпечатването на конзолата зависи от резултата:
//•	Ако сумата е достатъчна:
//o "Ivanovi will be left with {останали пари след почивката} leva after vacation."
//•	Ако НЕ е достигната сумата:
//o "{парите нужни до достигане на целта} leva needed."
//Сума трябва да се форматира до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		double budget = double.Parse(Console.ReadLine());
		int nights = int.Parse(Console.ReadLine());
		double nightPrice = double.Parse(Console.ReadLine());
		double additional = double.Parse(Console.ReadLine()) / 100 * budget;

		if (nights > 7) nightPrice *= 0.95;
		double total = nights * nightPrice + additional;
		if (budget >= total) Console.WriteLine("Ivanovi will be left with {0:f2} leva after vacation.", budget - total);
		else Console.WriteLine("{0:f2} leva needed.", total - budget);
	}
}