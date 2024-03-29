﻿//Деси трябва да заведе котката си на ветеринар в клиниката "Happy Cat", но паркингът се заплаща.
//Напишете програма, която пресмята колко общо трябва да се плати за престоя на колата на Деси на паркинга,
//за да заведе котката си на ветеринар. Паркингът е различен от останалите и има разнообразен ценоразпис.
//За всеки четен ден и нечетен час, паркингът таксува 2.50 лева. Във всеки нечетен ден и четен час таксата е 1.25 лева,
//във всички останали случаи се заплаща 1 лев. Таксуването става на всеки изминал час от деня.
//Всеки един от изходите трябва да бъде закръглен до втория знак след десетичната запетая.
//Вход
//От конзолата се четат два реда:
//•	Брой дни – цяло число в интервала [1 … 5]
//•	Брой часове за всеки един от дните - цяло число в интервала [1 … 24]
//Изход:
//Да се отпечата на конзолата:
//•	За всеки изминал ден, общата сума, която трябва да се плати – "Day: {индексът на деня} – {общата сума за деня} leva"
//•	Когато програмата приключи - "Total: {общата сума за всички дни} leva"

using System;

public class Program
{
	public static void Main()
	{
		int days = int.Parse(Console.ReadLine());
		int hours = int.Parse(Console.ReadLine());
		double total = 0;

		for (int day = 1; day <= days; day++)
		{
			double sumDay = 0;
			for (int hour = 1; hour <= hours; hour++)
			{
				if (day % 2 == 0 && hour % 2 == 1) sumDay += 2.50;
				else if (day % 2 == 1 && hour % 2 == 0) sumDay += 1.25;
				else sumDay += 1.00;
			}
			Console.WriteLine("Day: {0} - {1:f2} leva", day, sumDay);
			total += sumDay;
		}
		Console.WriteLine("Total: {0:f2} leva", total);
	}
}