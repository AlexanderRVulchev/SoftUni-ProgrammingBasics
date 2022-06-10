//Лили вече е на N години. За всеки свой рожден ден тя получава подарък. 
//•	За нечетните рождени дни (1, 3, 5...n) получава играчки.
//•	За четните рождени дни (2, 4, 6...n) получава пари.
//За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден (2 -> 10, 4 -> 20, 6 -> 30...и т.н.).
//През годините Лили тайно е спестявала парите. Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях.
//Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари. С парите искала да си купи пералня за X лева.
//Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.

using System;


internal class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingPrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());
        int toys = 0;
        double money = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 1) toys++;
            else money += i * 5.0 - 1.0;
        }
        money += toys * toyPrice;

        if (money >= washingPrice) Console.WriteLine("Yes! {0:f2}", money - washingPrice);
        else Console.WriteLine("No! {0:f2}", washingPrice - money);

    }
}