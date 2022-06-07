//Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях.
//Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
//При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.
//При обикновеното деление – резултата. При модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели.
//В този случай трябва да се отпечата специално съобщениe.
//Вход
//От конзолата се прочитат 3 реда, въведени от потребителя:
//•	N1 – цяло число в интервала [0...40 000]
//•	N2 – цяло число в интервала [0...40 000]
//•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
//Изход
//Да се отпечата на конзолата един ред:
//•	Ако операцията е деление:
//o "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
//•	Ако операцията е модулно деление: 
//o "{N1} % {N2} = {остатък}"
//•	В случай на деление с 0 (нула): 
//o "Cannot divide {N1} by zero"

using System;

public class Program
{
	public static void Main()
	{
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		string symbol = Console.ReadLine();

		switch (symbol)
		{
			case "+":
				{
					int result = n1 + n2;
					if (result % 2 == 1) Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
					else Console.WriteLine("{0} + {1} = {2} - even", n1, n2, result);
					break;
				}
			case "-":
				{
					int result = n1 - n2;
					if (Math.Abs(result % 2) == 1) Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result);
					else Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result);
					break;
				}
			case "*":
				{
					int result = n1 * n2;
					if (result % 2 == 1) Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result);
					else Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result);
					break;
				}
			case "/":
				{
					if (n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);
					else
					{
						double result = n1 * 1.0 / n2 * 1.0;
						Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
					}
					break;
				}
			case "%":
				{
					if (n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);
					else
					{
						int result = n1 % n2;
						Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
					}
					break;
				}
		}
	}
}