//Фирма - производител на алуминиева дограма приема поръчки за изработката и монтаж със следния ценоразпис за един брой.
//Фирмата приема само поръчки на едро (над 10 бр.). В зависимост от поръчания брой дограми, фирмата прави различна отстъпка на своите клиенти.
//Фирмата предлага също и доставка на поръчките си срещу 60 лв.
//Размер	Единична цена	Отстъпка от цената
//90X130	110 лв.	 Над 30 броя – 5%
// Над 60 броя – 8%
//100X150	140 лв.	 Над 40 броя – 6%
//   Над 80 броя – 10%
//130X180	190 лв.	 Над 20 броя – 7% 
//   Над 50 броя – 12%
//200X300	250 лв.	 Над 25 броя – 9%
//   Над 50 броя – 14%

//Ако поръчката надвишава 99 броя  – върху крайната цена се начисляват допълнителни
//4% отстъпка (след като се начисли цената за доставка, ако има такава).
//При поръчка под 10 бр. на конзолата да бъде изписано "Invalid order"
//Вход:
//Потребителят въвежда 3 реда:
//1.Брой дограми – цяло число в интервала [0..1000];
//2.Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
//3.Начин на получаване – текст
//•	С доставка - "With delivery" 
//•	Без доставка - "Without delivery"
//Изход:
//Извежда се едно число – стойността на поръчката, в следния формат:
//o "{Обща стойност на поръчката} BGN"
//Резултатът да се форматира до втори знак след десетичната запетая.

using System;


public class Program
{
    static void Main()
    {
        int amount = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        bool delivery = Console.ReadLine() == "With delivery";
        double price = 0;

        switch (type)
        {
            case "90X130":
                price = 110.00;
                if (amount > 60) price -= price * 0.08;
                else if (amount > 30) price -= price * 0.05;
                break;
            case "100X150":
                price = 140.00;
                if (amount > 80) price -= price * 0.10;
                else if (amount > 40) price -= price * 0.06;
                break;
            case "130X180":
                price = 190.00;
                if (amount > 50) price -= price * 0.12;
                else if (amount > 20) price -= price * 0.07;
                break;
            case "200X300":
                price = 250.00;
                if (amount > 50) price -= price * 0.14;
                else if (amount > 25) price -= price * 0.09;
                break;
        }
        double total = price * amount;
        if (delivery) total += 60.00;
        if (amount > 99) total -= total * 0.04;

        if (amount < 10) Console.WriteLine("Invalid order");
        else Console.WriteLine($"{total:f2} BGN");
    }
}