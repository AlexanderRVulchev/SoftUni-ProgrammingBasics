//Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто.
//Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.

using System;


namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            double coinValue = 200;
            int coins = 0;
            double money = double.Parse(Console.ReadLine());
            money = Math.Floor(money * 100);

            while (money > 0)
            {
                if (money >= coinValue)
                {
                    money -= coinValue;
                    coins++;
                }
                else
                {
                    if (coinValue == 2) coinValue = 1;
                    if (coinValue == 5) coinValue = 2;
                    if (coinValue == 10) coinValue = 5;
                    if (coinValue == 20) coinValue = 10;
                    if (coinValue == 50) coinValue = 20;
                    if (coinValue == 100) coinValue = 50;
                    if (coinValue == 200) coinValue = 100;
                }
            }
            Console.WriteLine(coins);
        }
    }
}