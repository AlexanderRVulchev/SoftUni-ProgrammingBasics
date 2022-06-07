//Лято е с много променливо време и Виктор има нужда от вашата помощ.
//Напишете програма която спрямо времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече.
//Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
//От конзолата се четат точно два реда:
//•	Градусите - цяло число в интервала [10…42]
//•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
//Време от денонощието / градуси	
//Мorning	
//Afternoon	
//Evening
//10 <= градуси <= 18	Outfit = Sweatshirt
//Shoes = Sneakers	Outfit = Shirt
//Shoes = Moccasins	Outfit = Shirt
//Shoes = Moccasins
//18 < градуси <= 24	Outfit = Shirt
//Shoes = Moccasins	Outfit = T-Shirt
//Shoes = Sandals	Outfit = Shirt
//Shoes = Moccasins
//градуси >= 25	Outfit = T-Shirt
//Shoes = Sandals	Outfit = Swim Suit
//Shoes = Barefoot	Outfit = Shirt
//Shoes = Moccasins
//Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."

using System;

public class Program
{
	public static void Main()
	{
		int degrees = int.Parse(Console.ReadLine());
		string time = Console.ReadLine();
		string outfit = "Shirt";
		string shoes = "Moccasins";

		if (degrees >= 10 && degrees <= 18)
		{
			if (time == "Morning") { outfit = "Sweatshirt"; shoes = "Sneakers"; }
		}
		if (degrees > 18 && degrees <= 24)
		{
			if (time == "Afternoon") { outfit = "T-Shirt"; shoes = "Sandals"; }
		}
		if (degrees >= 25)
		{
			if (time == "Morning") { outfit = "T-Shirt"; shoes = "Sandals"; }
			else if (time == "Afternoon") { outfit = "Swim Suit"; shoes = "Barefoot"; }
		}
		Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
	}
}