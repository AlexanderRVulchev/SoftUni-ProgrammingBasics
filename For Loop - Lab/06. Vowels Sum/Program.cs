//Да се напише програма, която чете текст (стринг), въведен от потребителя, и изчислява и отпечатва сумата от стойностите на гласните букви според таблицата по-долу:
//буква     a	e	i	o	u
//стойност	1	2	3	4	5

using System;

public class Program
{
	public static void Main()
	{
		string str = Console.ReadLine();
		int score = 0;
		for (int i = 0; i < str.Length; i++)
		{
			char letter = str[i];
			switch (letter)
			{
				case 'a': score += 1; break;
				case 'e': score += 2; break;
				case 'i': score += 3; break;
				case 'o': score += 4; break;
				case 'u': score += 5; break;
			}
		}
		Console.WriteLine(score);
	}
}