//Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума.
//Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.

using System;

internal class Program
{
    static void Main()
    {
        double vacationCost = double.Parse(Console.ReadLine());
        double money = double.Parse(Console.ReadLine());
        int spendCount = 0;
        int days = 0;

        while (money < vacationCost && spendCount < 5)
        {
            days++;
            string action = Console.ReadLine();
            double dailyMoney = double.Parse(Console.ReadLine());
            if (action == "save")
            {
                money += dailyMoney;
                spendCount = 0;
            }
            else if (action == "spend")
            {
                money -= dailyMoney;
                spendCount++;
                if (money < 0) money = 0;
            }
        }
        if (spendCount == 5) Console.WriteLine($"You can't save the money.\n{days}");
        else Console.WriteLine($"You saved the money for {days} days.");
    }
}