//Деси има рожден ден на Великден и иска да организира парти за своите приятели.
//Тя знае какъв е броят гости, които иска да покани и колко е кувертът за всеки гост.
//От броя гости зависи и каква отстъпка ще получи за куверта за един човек.
//Ако покани:
//•	Между 10(вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
//•	Между 15 и 20 (вкл.) човека-> 20 % отстъпка от куверта за един човек
//•	Над 20 човека -> 25 % отстъпка от куверта за един човек
//Деси трябва да предвиди и закупуването на торта за партито. Цената на тортата е 10% от бюджета на Деси.
//Напишете програма, която изчислява дали бюджетът на Деси ще и е достатъчен за партито.
//Вход
//От конзолата се четат 3 реда:
//1.Брой гости – цяло число в интервала [1...99]
//2.Цена на куверт за един човек – реално число в интервала [0.00 … 99.00]
//3.Бюджетът на Деси  – реално число в интервала [0.00 … 9999.00]
//Изход
//На конзолата да се отпечата един ред:
//•	Ако бюджетът  е достатъчен:
//o "It is party time! {останали пари} leva left."
//•	Ако бюджетът не е достатъчен:
//o "No party! {недостигащи пари} leva needed."
//Резултатът да бъде форматиран до втория знак след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		int people = int.Parse(Console.ReadLine());
		double couponPrice = double.Parse(Console.ReadLine());
		double budget = double.Parse(Console.ReadLine());
		double cake = 0.10 * budget;

		if (people > 20) couponPrice -= couponPrice * 0.25;
		else if (people > 15) couponPrice -= couponPrice * 0.20;
		else if (people >= 10) couponPrice -= couponPrice * 0.15;

		double total = couponPrice * people + cake;

		if (budget >= total) Console.WriteLine("It is party time! {0:f2} leva left.", budget - total);
		else Console.WriteLine("No party! {0:f2} leva needed.", total - budget);
	}
}