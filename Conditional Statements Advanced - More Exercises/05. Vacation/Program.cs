﻿//Напишете програма, която спрямо даден бюджет и сезон да пресмята цената, локацията и мястото на настаняване за ваканция.
//Сезоните са лято и зима – "Summer" и "Winter". Локациите са – "Alaska" и "Morocco".
//Възможните места за настаняване – "Hotel", "Hut" или "Camp".
//•	При бюджет по-малък или равен от 1000лв.:
//o Настаняване в "Camp"
//o	Според сезона локацията ще е една от следните и ще струва определен процент от бюджета:
//	Лято – Аляска – 65 % от бюджета
//	Зима – Мароко – 45 % от бюджета
//•	При бюджет по-голям от 1000лв. и по-малък или равен от 3000лв.:
//o Настаняване в "Hut"
//o	Според сезона локацията ще е една от следните и ще струва определен процент от бюджета:
//	Лято – Аляска – 80 % от бюджета
//	Зима – Мароко – 60 % от бюджета
//•	При бюджет по-голям от 3000лв.:
//o Настаняване в "Hotel"
//o	Според сезона локацията ще е една от следните и ще струва 90% от бюджета:
//	Лято – Аляска
//	Зима – Мароко
//Вход
//Входът се чете от конзолата и се състои от два реда:
//•	Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
//•	Втори ред –  Сезон – текст "Summer" или "Winter"
//Изход
//На конзолата трябва да се отпечатат един ред.
//"{локацията} – {мястото за настаняване} – {цената}"
//Цената трябва да е форматирана до вторият знак след десетичната запетая.

using System;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        bool isSummer = Console.ReadLine() == "Summer";
        string housing = "Hotel";
        string location = "Morocco";
        double cost;

        if (isSummer) location = "Alaska";
        if (budget <= 1000)
        {
            housing = "Camp";
            if (isSummer) cost = 0.65 * budget;
            else cost = 0.45 * budget;
        }
        else if (budget <= 3000)
        {
            housing = "Hut";
            if (isSummer) cost = 0.80 * budget;
            else cost = 0.60 * budget;
        }
        else cost = 0.90 * budget;

        Console.WriteLine($"{location} - {housing} - {cost:f2}");
    }
}