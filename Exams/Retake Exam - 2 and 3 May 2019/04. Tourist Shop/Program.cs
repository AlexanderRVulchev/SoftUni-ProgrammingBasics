//Времето се затопля и туристи, започват да си правят разходки високо в планината, където все още сняг,
//като за целта те трябва да закупят нужната туристическа екипировка.
//Вашата задача е да напишете програма, която да изчислява, стойността на екипировката,
//както и дали определения бюджет е достатъчен или не, като се знае, че в магазина има следната промоция:
//Всеки трети продукт е на половин цена.
//Вход
//От конзолата се чете:
//•	На първи ред – бюджетът - реално число в интервала [1.00… 100000.00]
//•	След това поредица от два реда (до получаване на команда "Stop" или при заявка за купуване на продукт,
//чиято стойност е по-висока от наличния бюджет) :
//o Име на продукта – текст
//o	Цена на продукта – реално число в интервала [1.00… 5000.00]
//Изход
//На конзолата да се отпечатат следните редове според случая:
//•	При получаване на командата "Stop", на един ред:
//o "You bought {брой на закупените продукти} products for {цена на покупките} leva."
//•	При заявка за покупка на продукт, чиято цена е по-висока от останалите пари, на два реда:
//o "You don't have enough money!"
//o "You need {недостигащи пари} leva!"

using System;


public class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int products = 0;
        double total = 0;

        while (input != "Stop")
        {
            double price = double.Parse(Console.ReadLine());
            if ((products + 1) % 3 == 0) price /= 2;
            total += price;
            if (budget < total) break;
            products++;
            input = Console.ReadLine();
        }

        if (budget < total)
        {
            Console.WriteLine($"You don't have enough money!");
            Console.WriteLine($"You need {(total - budget):f2} leva!");
        }
        else Console.WriteLine($"You bought {products} products for {total:f2} leva.");
    }
}