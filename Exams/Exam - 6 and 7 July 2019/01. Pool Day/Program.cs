//Преподавателският екип на СофтУни организира работен ден на басейн по случай настъпването на лятото.
//Вашата задача е да напишете програма, която да изчислява каква сума трябва да се заплати.
//За всеки един човек от екипа трябва да се заплати такса вход.
//Трябва да имате предвид, че един чадър стига за двама души.
//Знае се, че само 75% от екипа искат шезлонги.
//При изчислението на броя на чадърите и шезлонгите, техният брой да се закръгли до по-голямото цяло число.
//Вход
//От конзолата се четат 4 числа:
//1.Първи ред – брой на хората. Цяло число в интервала [1…100]
//2.Втори ред – такса вход.Реално число в интервала[0.00…50.00]
//3.	Трети ред – цена един за шезлонг. Реално число в интервала [0.00…50.00]
//4.	Четвърти ред – цена за един чадър. Реално число в интервала [0.00...50.00]
//Изход
//"{сумата за покриване на разходите} lv." 
//Резултатът да се форматира до втората цифра след десетичния знак.

using System;

public class Program
{
	public static void Main()
	{
		int people = int.Parse(Console.ReadLine());
		double entryFee = double.Parse(Console.ReadLine());
		double chairPrice = double.Parse(Console.ReadLine());
		double umbrellaPrice = double.Parse(Console.ReadLine());

		double umbrellaQty = Math.Ceiling(people / 2.0);
		double chairQty = Math.Ceiling(0.75 * people);

		double total = people * entryFee + umbrellaQty * umbrellaPrice + chairQty * chairPrice;
		Console.WriteLine("{0:f2} lv.", total);
	}
}