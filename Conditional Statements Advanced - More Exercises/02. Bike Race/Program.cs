//Предстои Вело състезание за благотворителност в което участниците са разпределени в младша("juniors") и старша("seniors") група.
//Парите се набавят от таксата за участие на велосипедистите. Според възрастовата група и вида на трасето на което ще се провежда състезанието, таксата е различна.
//Група	trail	cross-country	downhill	road
//juniors	5.50	8	12.25	20
//seniors	7	9.50	13.75	21.50
//Ако в "cross-country" състезанието се съберат 50 или повече участника(общо младши и старши), таксата намалява с 25%.
//Организаторите отделят 5% процента от събраната сума за разходи.
//Вход
//От конзолата се четат 2 числа и един стринг, всяко на отделен ред:
//•	Първият ред – броят младши велосипедисти. Цяло число в интервала [1…100]
//•	Вторият ред – броят старши велосипедисти. Цяло число в интервала [1… 100]
//•	Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"
//Изход
//Да се отпечата на конзолата едно число:
//"{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.

using System;

class Program
{
    static void Main(string[] args)
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        bool haveDiscount = type == "cross-country" && juniors + seniors >= 50;
        double total = 0;

        switch (type)
        {
            case "trail": total = juniors * 5.50 + seniors * 7.00; break;
            case "cross-country": total = juniors * 8.00 + seniors * 9.50; break;
            case "downhill": total = juniors * 12.25 + seniors * 13.75; break;
            case "road": total = juniors * 20.00 + seniors * 21.50; break;
        }
        if (haveDiscount) total *= 0.75;
        total *= 0.95;

        Console.WriteLine($"{total:f2}");
    }
}