//Напишете програма която да пресмята средният разход за месец на семейство за даден период време.
//За всеки месец разходите са следните:
//•	За ток – всеки месец е различен, ще се чете от конзолата
//•	за вода – 20 лв.
//•	за интернет – 15 лв.
//•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20%.
//За всеки разход трябва да се пресметне колко общо е платено за всички месеци.
//Вход
//Входът се чете от конзолата:
//•	Първи ред – месеците за които се търси средният разход – цяло число в интервала [1...100]
//•	За всеки месец – сметката за ток – реално число в интервала [1.00...1000.00]
//Изход
//Да се отпечата на конзолата 5 реда:
//•	1ви ред: "Electricity: {ток за всички месеци} lv"
//•	2ри ред: "Water: {вода за всички месеци} lv"
//•	3ти ред: "Internet: {интернет за всички месеци} lv"
//•	4ти ред: "Other: {други за всички месеци} lv"
//•	5ти ред: "Average: {средно всички разходи за месец} lv"
//Всички числа трябва да са форматирана до вторият знак след запетаята.

using System;

public class Program
{
	public static void Main()
	{
		int months = int.Parse(Console.ReadLine());
		double electricity = 0;
		double water = months * 20;
		double internet = months * 15;

		for (int i = 0; i < months; i++) electricity += double.Parse(Console.ReadLine());
		double other = (electricity + water + internet) * 1.2;
		double totalAvg = (electricity + water + internet + other) / months;

		Console.WriteLine("Electricity: {0:f2} lv", electricity);
		Console.WriteLine("Water: {0:f2} lv", water);
		Console.WriteLine("Internet: {0:f2} lv", internet);
		Console.WriteLine("Other: {0:f2} lv", other);
		Console.WriteLine("Average: {0:f2} lv", totalAvg);
	}
}