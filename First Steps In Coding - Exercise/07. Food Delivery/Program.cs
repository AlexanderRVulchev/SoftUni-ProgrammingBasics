//Ресторант отваря врати и предлага няколко менюта на преференциални цени: 
//•	Пилешко меню –  10.35 лв. 
//•	Меню с риба – 12.40 лв. 
//•	Вегетарианско меню  – 8.15 лв. 
//Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
//Групата ще си поръча и десерт, чиято цена е равна на 20% от общата сметка (без доставката). 
//Цената на доставка е 2.50 лв и се начислява най-накрая.  


using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            double chicken = double.Parse(Console.ReadLine()) * 10.35;
            double fish = double.Parse(Console.ReadLine()) * 12.40;
            double vegetarian = double.Parse(Console.ReadLine()) * 8.15;
            double dinner = chicken + fish + vegetarian;
            double desert = 0.2 * dinner;
            double total = dinner + desert + 2.50;
            Console.WriteLine(total);
        }
    }
}


