//Туристическа агенция има нужда от система за изчисляване на дължимата сума при резервация.
//В зависимост от различните дестинации и различните пакети, цената е различна.
//Цените за ден са следните:
//Цена за ден	Банско/Боровец	Варна/Бургас
//	с екипировка	без екипировка	със закуска	без закуска
//	100лв.	80лв	130лв.	100лв.
//VIP отстъпка	10%	5%	12%	7%
//Ако клиентът е заявил престой повече от 7 дни, получава единия ден безплатно.
//Вход
//От конзолата се четат 4 реда:
//1.Име на града - текст с възможности ("Bansko",  "Borovets", "Varna" или "Burgas")
//2.Вид на пакета - текст с възможности ("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
//3.Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
//4.	Дни за престой - цяло число в интервала [1 … 10000]
//Изход
//На конзолата се отпечатва 1 ред:
//•	Когато потребителят е въвел всички данни правилно, отпечатваме: 
//"The price is {цената, форматирана до втория знак}lv! Have a nice time!"
//•	Ако потребителят е въвел по-малко от 1 ден за престой, отпечатваме: 
//"Days must be positive number!"
//•	Когато при въвеждането на града или вида на пакета се въведат невалидни данни, отпечатваме: "Invalid input!"

using System;

public class Program
{
	public static void Main()
	{
		string town = Console.ReadLine();
		string packet = Console.ReadLine();
		string vip = Console.ReadLine();
		int days = int.Parse(Console.ReadLine());
		bool wrongDays = false;
		bool invalidInput = false;
		double price = 0;

		if (days < 1) wrongDays = true;

		switch (town)
		{
			case "Bansko":
			case "Borovets":
				if (packet == "withEquipment") price = 100.00;
				else if (packet == "noEquipment") price = 80.00;
				else invalidInput = true;
				break;
			case "Varna":
			case "Burgas":
				if (packet == "withBreakfast") price = 130.00;
				else if (packet == "noBreakfast") price = 100.00;
				else invalidInput = true;
				break;
			default: invalidInput = true; break;
		}

		if (vip == "yes")
			switch (packet)
			{
				case "withEquipment": price *= 0.90; break;
				case "noEquipment": price *= 0.95; break;
				case "withBreakfast": price *= 0.88; break;
				case "noBreakfast": price *= 0.93; break;
				default: break;
			}
		if (days > 7) days--;
		double total = price * days;

		if (invalidInput == true) Console.WriteLine("Invalid input!");
		else if (wrongDays == true) Console.WriteLine("Days must be positive number!");
		else Console.WriteLine("The price is {0:f2}lv! Have a nice time!", total);
	}
}