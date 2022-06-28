//Пешо решава, че иска да направи ремонт вкъщи. Неговата задача е да боядиса стените в хола,
//като знаете височината и ширината на една стена. Холът на Пешо има 4 стени с еднакви размери,
//определен процент от които се заемат от прозорци и врати, които няма да бъдат боядисвани.
//Той не е сигурен дали ще успее наведнъж, затова моли Вас да му помогнете да изчисли дали ще му остава още работа за следващия ден и,
//ако да, колко кв. м. има да довърши, а в случай, че успее да боядиса хола, колко боя му е останала
//(трябва да се има предвид, че с един литър боя се боядисва един квадратен метър от стената). 
//Вход
//От конзолата се четат следните редове:
//1.Височина на стената - цяло число [0… 100]
//2.Ширина на стената - цяло число [0… 100]
//3.Процент от общата площ на стените, който няма да бъде боядисан - цяло число [5… 95]
//На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички стени, се чете по едно число:
//•	Литри боя – цяло число [0…100]:
//Забележка: Площта за боядисване да бъде закръглена нагоре до най-близкото цяло число.
//Изход
//Да се отпечата на конзолата един от следните редове:
//•	При получаване на командата "Tired!":
//"{квадратни метри} quadratic m left."
//{ квадратни метри}
//е повърхнината, която му остава да боядисана.
//•	Aко е останала боя в излишък:
//"All walls are painted and you have {литри боя} l
// paint left!" 
//•	Aко след боядисването на всички стени, не е останала боя:
//"All walls are painted! Great job, Pesho!"

using System;

public class Program
{
	public static void Main()
	{
		int height = int.Parse(Console.ReadLine());
		int width = int.Parse(Console.ReadLine());
		double redundant = double.Parse(Console.ReadLine()) / 100.0;

		int area = int.Parse(Math.Ceiling(4.0 * height * width * (1 - redundant)).ToString());
		string input = Console.ReadLine();

		while (input != "Tired!")
		{
			area -= int.Parse(input);
			if (area <= 0) break;
			input = Console.ReadLine();
		}

		if (area > 0) Console.WriteLine("{0} quadratic m left.", area);
		else if (area < 0) Console.WriteLine("All walls are painted and you have {0} l paint left!", Math.Abs(area));
		else Console.WriteLine("All walls are painted! Great job, Pesho!");
	}
}