//Напишете програма, която отпечатва числата в диапазона от 1 до 1000, които завършват на 7.

using System;

public class Program
{
	public static void Main()
	{
		for (int i = 7; i <= 1000; i += 10) Console.WriteLine(i);
	}
}