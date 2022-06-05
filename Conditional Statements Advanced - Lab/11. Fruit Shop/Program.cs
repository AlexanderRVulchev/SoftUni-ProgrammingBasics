//Магазин за плодове през работните дни работи на следните цени:
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.50	1.20	0.85	1.45	2.70	5.50	3.85
//Събота и неделя магазинът работи на по-високи цени:
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.70	1.25	0.90	1.60	3.00	5.60	4.20
//Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
//ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество(реално число) ,
//въведени от потребителя, и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
//При невалиден ден от седмицата или невалидно име на плод да се отпечата "error". 

using System;

public class Program
{
	public static void Main()
	{
		string fruit = Console.ReadLine();
		string day = Console.ReadLine();
		double quantity = double.Parse(Console.ReadLine());
		double price = 0.0;
		double total = 0.0;
		bool valid = true;

		switch (day)
		{
			case "Monday":
			case "Tuesday":
			case "Wednesday":
			case "Thursday":
			case "Friday":
				switch (fruit)
				{
					case "banana": price = 2.50; break;
					case "apple": price = 1.20; break;
					case "orange": price = 0.85; break;
					case "grapefruit": price = 1.45; break;
					case "kiwi": price = 2.70; break;
					case "pineapple": price = 5.50; break;
					case "grapes": price = 3.85; break;
					default: valid = false; break;
				}
				break;
			case "Saturday":
			case "Sunday":
				switch (fruit)
				{
					case "banana": price = 2.70; break;
					case "apple": price = 1.25; break;
					case "orange": price = 0.90; break;
					case "grapefruit": price = 1.60; break;
					case "kiwi": price = 3.00; break;
					case "pineapple": price = 5.60; break;
					case "grapes": price = 4.20; break;
					default: valid = false; break;
				}
				break;
			default: valid = false; break;
		}
		total = price * quantity;
		if (valid) Console.WriteLine("{0:f2}", total);
		else Console.WriteLine("error");

	}
}
