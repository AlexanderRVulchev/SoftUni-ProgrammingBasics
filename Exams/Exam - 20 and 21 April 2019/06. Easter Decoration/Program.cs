//За великденските празници, магазин започва да продава три вида великденска украса – кошнички за яйца (basket),
//великденски венци(wreath) и шоколадови зайци (chocolate bunny).
//Вашата задача е да напишете програма, която да изчислява каква сметка трябва да плати всеки един клиент на магазина,
//като се има в предвид, че всеки клиент закупил четен брой продукти, ще получи 20% отстъпка от крайната цена.
//След като всички клиенти приключат с покупките, трябва да се отпечата средно по колко пари е похарчил всеки човек.
//Цените на продуктите са:
//•	кошничка за яйца (basket) – 1.50 лв.
//•	великденски венец(wreath) – 3.80 лв.
//•	шоколадов заек(chocolate bunny) – 7 лв.
//Вход
//От конзолата първоначално се чете един ред:
//•	Брои на клиентите в магазина – цяло число [1… 100]
//•	След това за всеки един клиент на нов ред до получаване на командата "Finish" се чете:
//o Покупката която клиента е избрал – текст ("basket", "wreath" или "chocolate bunny")
//Изход
//•	При получаване на командата "Finish" да се отпечата един ред:
//o "You purchased {броя на покупките} items for {крайната цена} leva."
//•	Накрая, след като всички клиенти приключат с покупките, да се отпечата на един ред
//o	"Average bill per client is: {средно аритметично на парите които е похарчил всеки един клиент} leva."
//Всички пари трябва да бъдат форматирани до втората цифра след десетичния знак.

using System;


internal class Program
{
    static void Main()
    {
        int clients = int.Parse(Console.ReadLine());
        double totalAllclients = 0;

        for (int i = 1; i <= clients; i++)
        {
            double totalThisClient = 0;
            int itemsCount = 0;
            string input = Console.ReadLine();
            while (input != "Finish")
            {
                switch (input)
                {
                    case "basket": totalThisClient += 1.50; break;
                    case "wreath": totalThisClient += 3.80; break;
                    case "chocolate bunny": totalThisClient += 7.00; break;
                }
                itemsCount++;
                input = Console.ReadLine();
            }
            if (itemsCount % 2 == 0) totalThisClient -= totalThisClient * 0.2;
            Console.WriteLine($"You purchased {itemsCount} items for {totalThisClient:f2} leva.");
            totalAllclients += totalThisClient;
        }
        Console.WriteLine($"Average bill per client is: {(totalAllclients / clients):f2} leva.");
    }
}