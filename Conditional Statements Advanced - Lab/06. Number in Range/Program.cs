//Да се напише програма, която проверява дали въведеното от потребителя число е в интервала [-100, 100] и е различно от 0
//и извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.

using System;

public class Program
{
	public static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		bool inRange = false;

		if (number >= -100 && number <= 100 && number != 0) inRange = true;

		if (inRange) Console.WriteLine("Yes");
		else Console.WriteLine("No");
	}
}