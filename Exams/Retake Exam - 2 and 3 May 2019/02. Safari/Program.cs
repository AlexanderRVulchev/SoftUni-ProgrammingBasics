//Симона и Светлин ще ходят на почивка в Африка и искат да отидат на сафари.
//Понеже за делничните дни вече имат планове, решават, че ще отидат събота или неделя.
//Напишете програма, която изчислява колко ще им струва ходенето на сафари и дали бюджетът им ще им стигне да отидат, като имате предвид следното:
//•	Цената на един литър гориво е 2.10 лв.
//•	Цената за екскурзовод е 100лв.
//•	В зависимост от деня има отстъпки от общата цена - за събота 10%, а за неделя 20%
//Вход
//От конзолата се четат 3 реда:
//•	Бюджет – реално число в интервала [0.00… 10000.00]
//•	Колко литра гориво ще са им нужни – реално число в интервала [1.00… 50.00]
//•	Ден от седмицата – текст с възможности "Saturday" и "Sunday" 
//Изход
//Да се отпечата на конзолата един ред:  
//•	Ако бюджетът е достатъчен:
//"Safari time! Money left: {колко пари са им останали} lv. "
//•	Ако бюджетът не е достатъчен:
//"Not enough money! Money needed: {колко пари не им достигат} lv."
//Сумите трябва да са форматирани до втория знак след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		double budget = double.Parse(Console.ReadLine());
		double fuel = double.Parse(Console.ReadLine());
		string day = Console.ReadLine();

		double total = fuel * 2.10 + 100.00;
		if (day == "Saturday") total -= total * 0.10;
		if (day == "Sunday") total -= total * 0.20;

		if (budget >= total)
			Console.WriteLine("Safari time! Money left: {0:f2} lv. ", budget - total);
		else
			Console.WriteLine("Not enough money! Money needed: {0:f2} lv.", total - budget);
	}
}