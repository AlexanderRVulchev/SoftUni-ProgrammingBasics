//Напишете програма, която да умножава положителни числа по 2.
//От конзолата се четат поредица от реални числа, всяко на нов ред, докато не се въведе отрицателно.
//След всяко умножено число на нов ред да се отпечата "Result: {резултата от умножението}".
//Резултата от умножението да бъде форматиран до втория знак след десетичния разделител.
//При получаване на негативно число, на конзолата да се отпечата "Negative number!" и програмата да приключи изпълнение.

using System;

public class Program
{
	public static void Main()
	{
		while (true)
		{
			double num = double.Parse(Console.ReadLine());
			if (num < 0)
			{
				Console.WriteLine("Negative number!");
				break;
			}
			else Console.WriteLine("Result: {0:f2}", num * 2);
		}
	}
}