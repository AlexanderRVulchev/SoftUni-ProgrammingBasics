//Напишете програма, която чете текст (стринг), въведен от потребителя и печата всеки символ от текста на отделен ред.

using System;

public class Program
{
	public static void Main()
	{
		string str = Console.ReadLine();

		for (int i = 0; i < str.Length; i++)
		{
			char letter = str[i];
			Console.WriteLine(letter);
		}
	}
}