//Гошо работи в ресторант и отговаря за зареждането на съдомиялната накрая на деня.
//Вашата задача е да напишете програма, която изчислява, дали дадено закупено количество бутилки от препарат за съдомиялна е достатъчно,
//за да измие определено количество съдове. Знае се, че всяка бутилка съдържа 750 мл. препарат, за 1 чиния са нужни 5 мл., а за тенджера 15 мл.
//Приемете, че на всяко трето зареждане със съдове, съдомиялната се пълни само с тенджери, а останалите пъти с чинии.
//Докато не получите команда "End" ще продължите да получавате бройка съдове, които трябва да бъдат измити.
//Вход
//От конзолата се четат:
//•	Брой бутилки от препарат, който ще бъде използван за миенето на чинии - цяло число в интервала [1…10]
//На всеки следващ ред, до получаване на командата "End" или докато количеството препарат не се изчерпи,
//брой съдове, които трябва да бъдат измити - цяло число в интервала [1…100]
//Изход
//В случай, че количеството препарат е било достатъчно за измиването на съдовете:
//"Detergent was enough!"
//"{брой чисти чинии} dishes and {брой чисти тенджери} pots were washed."
//"Leftover detergent {количество останал препарат} ml."
//В случай, че количеството препарат не е било достатъчно за измиването на съдовете:
//"Not enough detergent, {количество не достигнал препарат} ml. more necessary!"

using System;

public class Program
{
	public static void Main()
	{
		double detergent = double.Parse(Console.ReadLine()) * 750;
		int dishes = 0;
		int pots = 0;
		int counter = 1;

		string input = Console.ReadLine();
		while (input != "End")
		{
			int num = int.Parse(input);
			if (counter % 3 == 0) { pots += num; detergent -= num * 15; }
			else { dishes += num; detergent -= num * 5; }
			counter++;
			if (detergent < 0) { Console.WriteLine("Not enough detergent, {0} ml. more necessary!", Math.Abs(detergent)); return; }
			input = Console.ReadLine();
		}
		Console.WriteLine("Detergent was enough!");
		Console.WriteLine("{0} dishes and {1} pots were washed.", dishes, pots);
		Console.WriteLine("Leftover detergent {0} ml.", detergent);
	}
}