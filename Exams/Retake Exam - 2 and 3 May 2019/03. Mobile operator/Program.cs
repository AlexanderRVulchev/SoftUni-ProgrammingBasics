//Мобилен оператор предлага договори с различна месечна такса в зависимост от срока - 1 или 2 години.
//Да се напише програма, която изчислява дължимата сума, която трябва да се плати за определен брой месеци.
//срок / тип	Small	Middle	Large	ExtraLarge
//1 година(one)	9.98 лв.    18.99 лв.   25.98 лв.   35.99 лв.
//2 години(two)   8.58 лв.    17.09 лв.   23.59 лв.   31.79 лв.
//Условия:
//•	при добавен мобилен интернет, към таксата за един месец се добавя:
//o при такса по-малка или равна на 10.00 лв.  5.50 лв.
//o	при такса по-малка или равна на 30.00 лв.  4.35 лв.
//o	при такса по-голяма от 30.00 лв.  3.85 лв.
//•	ако договорът e за две години, общата сума се намалява с 3.75%
//Вход
//От конзолата се четат 3 реда:
//1.Срок на договор – текст – "one", или "two"
//2.	Тип на договор – текст – "Small",  "Middle", "Large"или "ExtraLarge"
//3.	Добавен мобилен интернет – текст – "yes" или "no"
//4.	Брой месеци за плащане - цяло число в интервала [1 … 24]
//Изход
//На конзолата се отпечатва 1 ред:
//•	Цената, която заплаща клиентът, форматирана до втория знак след десетичната запетая, в следния формат:  "{цената} lv."

using System;


public class Program
{
    static void Main()
    {
        string duration = Console.ReadLine();
        string type = Console.ReadLine();
        string internet = Console.ReadLine();
        int months = int.Parse(Console.ReadLine());
        double cost = 0;

        switch (type)
        {
            case "Small":
                if (duration == "one") cost = 9.98;
                else cost = 8.58;
                break;
            case "Middle":
                if (duration == "one") cost = 18.99;
                else cost = 17.09;
                break;
            case "Large":
                if (duration == "one") cost = 25.98;
                else cost = 23.59;
                break;
            case "ExtraLarge":
                if (duration == "one") cost = 35.99;
                else cost = 31.79;
                break;
        }

        if (internet == "yes")
        {
            if (cost <= 10) cost += 5.50;
            else if (cost <= 30) cost += 4.35;
            else cost += 3.85;
        }

        if (duration == "two") cost -= 0.0375 * cost;

        cost *= months;

        Console.WriteLine($"{cost:f2} lv.");
    }
}