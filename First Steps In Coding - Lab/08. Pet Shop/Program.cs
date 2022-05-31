//Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.  
//Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв, 
//а опаковка храна за котки струва 4 лв.

using System;

namespace Presentation
{
    internal class Program
    {
        static void Main()
        {
            int dogNumber = int.Parse(Console.ReadLine());
            int catNumber = int.Parse(Console.ReadLine());
            double dogfoodPrice = 2.50;
            double catfoodPrice = 4.00;

            double total = dogNumber * dogfoodPrice + catNumber * catfoodPrice;
            Console.WriteLine($"{total} lv.");
        }
    }
}
