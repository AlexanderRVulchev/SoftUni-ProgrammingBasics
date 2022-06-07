﻿//Странно, но повечето хора си плануват от рано почивката.
//Млад програмист разполага с определен бюджет и свободно време в даден сезон. Н
//апишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
//Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел.
//Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
//•	При 100лв.или по-малко – някъде в България
//o	Лято – 30% от бюджета
//o	Зима – 70% от бюджета
//•	При 1000лв. или по малко – някъде на Балканите
//o	Лято – 40% от бюджета
//o	Зима – 80% от бюджета
//•	При повече от 1000лв. – някъде из Европа
//o	При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета.
//Вход
//Входът се чете от конзолата и се състои от два реда, въведени от потребителя:
//•	Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
//•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
//Изход
//На конзолата трябва да се отпечатат два реда.
//•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria ", "Balkans” и ”Europe”
//•	Втори ред – “{Вид почивка} – { Похарчена сума}“
//o Почивката може да е между „Camp” и „Hotel”
//o	Сумата трябва да е закръглена с точност до вторият знак след запетаята.

using System;


internal class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double total = 0;
        string destination = "";
        string housing = "";

        if (budget <= 100)
        {
            destination = "Bulgaria";
            switch (season)
            {
                case "summer": total = 0.3 * budget; housing = "Camp"; break;
                case "winter": total = 0.7 * budget; housing = "Hotel"; break;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            switch (season)
            {
                case "summer": total = 0.4 * budget; housing = "Camp"; break;
                case "winter": total = 0.8 * budget; housing = "Hotel"; break;
            }
        }
        else
        {
            destination = "Europe";
            total = 0.9 * budget;
            housing = "Hotel";
        }
        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:f2}", housing, total);

    }
}
