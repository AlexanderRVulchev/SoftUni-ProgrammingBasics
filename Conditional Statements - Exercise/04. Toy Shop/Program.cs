//Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни.
//С парите, които ще спечели иска да отиде на екскурзия. 
//Цени на играчките:
//•	Пъзел - 2.60 лв.
//•	Говореща кукла - 3 лв.
//•	Плюшено мече - 4.10 лв.
//•	Миньон - 8.20 лв.
//•	Камионче - 2 лв.
//Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена.
//От спечелените пари Петя трябва да даде 10% за наема на магазина.
//Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.

using System;

internal class Program
{
    static void Main()
    {
        double vacationPrice = double.Parse(Console.ReadLine());
        int puzzlesAmount = int.Parse(Console.ReadLine());
        int dollsAmount = int.Parse(Console.ReadLine());
        int bearsAmount = int.Parse(Console.ReadLine());
        int minionAmount = int.Parse(Console.ReadLine());
        int truckAmount = int.Parse(Console.ReadLine());

        double puzzles = puzzlesAmount * 2.60;
        double dolls = dollsAmount * 3.00;
        double bears = bearsAmount * 4.10;
        double minion = minionAmount * 8.20;
        double truck = truckAmount * 2.00;

        double total = puzzles + dolls + bears + minion + truck;
        int toysNum = puzzlesAmount + dollsAmount + bearsAmount + minionAmount + truckAmount;
        if (toysNum >= 50) total -= 0.25 * total;
        total -= 0.1 * total;

        if (total >= vacationPrice) Console.WriteLine($"Yes! {(total - vacationPrice):f2} lv left.");
        else Console.WriteLine($"Not enough money! {(vacationPrice - total):f2} lv needed.");
    }
}