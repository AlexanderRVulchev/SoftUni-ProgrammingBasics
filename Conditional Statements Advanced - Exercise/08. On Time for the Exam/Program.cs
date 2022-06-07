//Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40).
//Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
//Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял.
//Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали
//студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
//Вход
//От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
//•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
//•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
//•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
//•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
//Изход
//На първият ред отпечатайте:
//•	“Late”, ако студентът пристига по-късно от часа на изпита.
//•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
//•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
//Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
//•	
//“mm minutes after the start” за закъснение под час.
//•	“hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.

using System;

public class Program
{
	public static void Main()
	{
		int hourExam = int.Parse(Console.ReadLine());
		int minuteExam = int.Parse(Console.ReadLine());
		int hourArrival = int.Parse(Console.ReadLine());
		int minuteArrival = int.Parse(Console.ReadLine());

		int difference = (hourArrival * 60 + minuteArrival) - (hourExam * 60 + minuteExam);
		int hh = Math.Abs(difference) / 60;
		int mm = Math.Abs(difference) % 60;

		if (difference == 0) Console.WriteLine("On time");
		else if (difference > 0)
		{
			Console.WriteLine("Late");
			if (hh == 0) Console.WriteLine("{0} minutes after the start", mm);
			else if (mm < 10) Console.WriteLine("{0}:0{1} hours after the start", hh, mm);
			else Console.WriteLine("{0}:{1} hours after the start", hh, mm);
		}
		else if (difference < 0 && difference >= -30)
		{
			Console.WriteLine("On time");
			if (hh == 0) Console.WriteLine("{0} minutes before the start", mm);
			else if (mm < 10) Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
			else Console.WriteLine("{0}:{1} hours before the start", hh, mm);
		}
		else if (difference < -30)
		{
			Console.WriteLine("Early");
			if (hh == 0) Console.WriteLine("{0} minutes before the start", mm);
			else if (mm < 10) Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
			else Console.WriteLine("{0}:{1} hours before the start", hh, mm);
		}


	}
}