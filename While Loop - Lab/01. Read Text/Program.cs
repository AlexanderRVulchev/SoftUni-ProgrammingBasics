//Напишете програма, която чете текст от конзолата (стринг) и го принтира, докато не получи командата "Stop".

using System;

public class Program
{
	public static void Main()
	{
		string str = "";
		while (true)
		{
			str = Console.ReadLine();
			if (str == "Stop") break;
			Console.WriteLine(str);
		}
	}
}