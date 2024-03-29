﻿//Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване. Според размера на групата, катерачите ще изкачват различни върхове.
//•	Група до 5 човека – изкачват Мусала
//•	Група от 6 до 12 човека – изкачват Монблан
//•	Група от 13 до 25 човека – изкачват Килиманджаро
//•	Група от 26 до 40 човека –  изкачват К2
//•	Група от 41 или повече човека – изкачват Еверест
//Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.
//Вход
//От конзолата се четат поредица от числа, всяко на отделен ред:
//•	На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
//•	За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала [1...1000]
//Изход
//Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00% и 100.00% с точност до втората цифра след десетичната запетая.
//•	Първи ред - процентът изкачващи Мусала
//•	Втори ред – процентът изкачващи Монблан
//•	Трети ред – процентът изкачващи Килиманджаро
//•	Четвърти ред – процентът изкачващи К2
//•	Пети ред – процентът изкачващи Еверест

using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int total = 0;
        int musala = 0;
        int monblan = 0;
        int kilim = 0;
        int k2 = 0;
        int everest = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 5) musala += num;
            else if (num <= 12) monblan += num;
            else if (num <= 25) kilim += num;
            else if (num <= 40) k2 += num;
            else everest += num;
            total += num;
        }
        Console.WriteLine("{0:f2}%", musala * 100.0 / total);
        Console.WriteLine("{0:f2}%", monblan * 100.0 / total);
        Console.WriteLine("{0:f2}%", kilim * 100.0 / total);
        Console.WriteLine("{0:f2}%", k2 * 100.0 / total);
        Console.WriteLine("{0:f2}%", everest * 100.0 / total);

    }
}