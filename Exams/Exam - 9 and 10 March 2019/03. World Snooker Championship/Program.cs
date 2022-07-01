//С наближаването на световното първенство по снукър в театъра Крусибъл в Шефилд, Англия,
//феновете нямат търпение да се сдобият с ценните билети. Заради големия наплив от хора,
//организаторите ви молят да напишете програма за продаване на билети, като се има предвид следния ценоразпис:
//	Четвъртфинал Полуфинал	Финал
//Стандартен	55.50 £/бр.	75.88 £/бр.	110.10 £/бр.
//Премиум	105.20 £/бр.	125.22 £/бр.	160.66 £/бр.
//ВИП	118.90 £/бр.	300.40 £/бр.	400 £/бр.
//При закупуване на билет, зрителят може да избере опция, снимка с трофея, на цена 40 лири.
//При достигане на определена сума има отстъпки:
//•	Над 4000 лири има 25% отстъпка и безплатни снимки с трофея (ако  опцията за снимки е избрана, таксата от 40 лири за билет не се включва)
//•	Над 2500 лири има 10% отстъпка
//При избрана опция за снимки с трофея, цената се начислява след изчисляването на отстъпките.
//Вход
//От конзолата се четат 3 реда:
//1.Етап на първенството – текст - “Quarter final ”, “Semi final” или “Final”
//2.	Вид на билета – текст - “Standard”, “Premium” или “VIP”
//3.	Брой билети – цяло число в интервала [1 … 30]
//4.Снимка с трофея – символ – 'Y' (да) или 'N'(не)
//Изход
//На конзолата се отпечатва 1 ред:
//•	"Цената, която трябва да се заплати, форматирана до втората цифра след десетичния знак"

using System;


public class Program
{
    static void Main()
    {
        string stage = Console.ReadLine();
        string type = Console.ReadLine();
        int tickets = int.Parse(Console.ReadLine());
        double ticketCost = 0;
        double total = 0;

        string inputPhoto = Console.ReadLine();
        bool wantPhoto = false;
        if (inputPhoto == "Y") wantPhoto = true;

        switch (stage)
        {
            case "Quarter final":
                if (type == "Standard") ticketCost = 55.50;
                if (type == "Premium") ticketCost = 105.20;
                if (type == "VIP") ticketCost = 118.90;
                break;
            case "Semi final":
                if (type == "Standard") ticketCost = 75.88;
                if (type == "Premium") ticketCost = 125.22;
                if (type == "VIP") ticketCost = 300.40;
                break;
            case "Final":
                if (type == "Standard") ticketCost = 110.10;
                if (type == "Premium") ticketCost = 160.66;
                if (type == "VIP") ticketCost = 400.00;
                break;
        }
        total = ticketCost * tickets;

        if (total > 4000)
        {
            total = 0.75 * total;
            wantPhoto = false;
        }
        else if (total > 2500)
        {
            total = 0.90 * total;
        }
        if (wantPhoto) total += 40.00 * tickets;

        Console.WriteLine($"{total:f2}");
    }
}
