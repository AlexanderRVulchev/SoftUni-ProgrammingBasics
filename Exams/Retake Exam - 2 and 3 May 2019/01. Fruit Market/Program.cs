//Мария решава да мине на диета и отива до близкия пазар, за да купи ягоди, банани, портокали и малини.
//На конзолата се въвежда цената на ягодите в лв./кг. и количеството на бананите, портокалите, малините и ягодите,
//които трябва да закупи. Да се напише програма, която пресмята колко пари са ѝ необходими за да плати сметката, като знаете, че:
//•	цената на малините е на половина по-ниска от тази на ягодите;
//•	цената на портокалите е с 40% по-ниска от цената на малините;
//•	цената на бананите е с 80% по-ниска от цената на малините.
//Вход
//От конзолата се четат 5 реда:
//1.Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
//2.Количество на бананите в килограми – реално число в интервала [0.00 … 1 0000.00]
//3.Количество на портокалите в килограми – реално число в интервала [0.00 … 10000.00]
//4.Количество на малините в килограми – реално число в интервала [0.00 … 10000.00]
//5.Количество на ягодите в килограми – реално число в интервала [0.00 … 10000.00]
//Изход
//Да се отпечата на конзолата едно число:
//•	парите, които са необходими на Мария.
//Резултатът да се форматира до вторта цифра след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		double strawberryPrice = double.Parse(Console.ReadLine());
		double bananaKg = double.Parse(Console.ReadLine());
		double orangeKg = double.Parse(Console.ReadLine());
		double raspberryKg = double.Parse(Console.ReadLine());
		double strawberryKg = double.Parse(Console.ReadLine());

		double raspberryPrice = 0.5 * strawberryPrice;
		double orangePrice = 0.6 * raspberryPrice;
		double bananaPrice = 0.2 * raspberryPrice;

		double total = strawberryPrice * strawberryKg + bananaPrice * bananaKg + orangePrice * orangeKg + raspberryPrice * raspberryKg;
		Console.WriteLine("{0:f2}", total);
	}
}