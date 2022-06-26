//Напишете програма, която генерира и принтира на конзолата четирицифрени числа,
//в които първата и втората двойка цифри образуват двуцифрени прости числа (пример за такова число 1723).
//Крайната стойност до която трябва да се генерират двойките се определя от други 2 цифри, подадени като вход,
//които определят с колко крайната стойност е по-голяма от началната.
//Вход
//От конзолата се четат четири реда:
//•	На първия ред – началната стойност на първите първата двойка числа – цяло положително число в диапазона [10… 90]
//•	На втория ред – началната стойност на втората двойка числа – цяло положително число в диапазона [10… 90]
//•	На третия ред – разликата между началната и крайната стойност на  първата двойка числа – цяло положително число в диапазона [1… 9]
//•	На четвъртия ред – разликата между началната и крайната стойност на  втората двойка числа – цяло положително число в диапазона [1… 9]
//Изход:
//Да се отпечатат на конзолата четирицифрените числа, в които първите две и вторите две цифри са прости двуцифрени числа.

using System;

public class Program
{
	public static void Main()
	{
		int pair1Low = int.Parse(Console.ReadLine());
		int pair2Low = int.Parse(Console.ReadLine());
		int pair1High = int.Parse(Console.ReadLine()) + pair1Low;
		int pair2High = int.Parse(Console.ReadLine()) + pair2Low;

		for (int first = pair1Low; first <= pair1High; first++)
			for (int second = pair2Low; second <= pair2High; second++)
			{
				bool bothAreSimple = true;
				for (int div = 2; div <= first / 2; div++)
					if (first % div == 0) bothAreSimple = false;
				for (int div = 2; div <= second / 2; div++)
					if (second % div == 0) bothAreSimple = false;
				if (bothAreSimple) Console.WriteLine("{0}{1}", first, second);
			}
	}
}