//Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло число,
//въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 

using System;

public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());

		if (num >= 100 && num <= 200 || num == 0) ;
		else Console.WriteLine("invalid");

	}
}