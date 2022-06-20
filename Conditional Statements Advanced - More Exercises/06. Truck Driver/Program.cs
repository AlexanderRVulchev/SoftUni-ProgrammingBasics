//Напишете програма която пресмята колко пари ще изкара шофьор на ТИР за един сезон. На входа програмата получава през кой сезон ще работи шофьора, както и колко километра на месец ще кара. Един сезон е 4 месеца. Според зависи сезона и броя километри на месец ще му се заплаща различна сума на километър:

//	Пролет / Есен Лято Зима
//км на месец <= 5000	0.75 лв./км	0.90 лв./км	1.05 лв./км
//5000 < км на месец <= 10000	0.95 лв./км	1.10 лв./км	1.25 лв./км
//10000 < км на месец <= 20000	1.45 лв./км – за който и да е сезон

//След като са извадени 10% за данъци се отпечатват останалите пари.
//Вход
//Входът се чете от конзолата и се състои от два реда:
//•	Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
//•	Втори ред –  Километри на месец – реално число в интервала [10.00...20000.00]
//Изход
//На конзолата трябва да се отпечатат едно число:
//•	Заплатата на шофьора след данъците, форматирана до втория знак след десетичната запетая.

using System;

class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        double kmMonth = double.Parse(Console.ReadLine());
        double total = kmMonth * 1.45;

        if (kmMonth <= 5000)
        {
            switch (season)
            {
                case "Spring":
                case "Autumn": total = kmMonth * 0.75; break;
                case "Summer": total = kmMonth * 0.90; break;
                case "Winter": total = kmMonth * 1.05; break;
            }
        }
        else if (kmMonth <= 10000)
        {
            switch (season)
            {
                case "Spring":
                case "Autumn": total = kmMonth * 0.95; break;
                case "Summer": total = kmMonth * 1.10; break;
                case "Winter": total = kmMonth * 1.25; break;
            }
        }
        total *= 4;
        total *= 0.9;
        Console.WriteLine("{0:f2}", total);
    }
}