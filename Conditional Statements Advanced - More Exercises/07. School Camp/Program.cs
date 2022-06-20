//Частно училище организира лагери за учениците по време на ваканциите.
//В зависимост от вида на ваканцията (пролетна, лятна или зимна) и вида на групата (момчета/момичета или смесена)
//цената на нощувката в хотела е различна, както и спортът, който ще практикуват учениците.
//	Зимна ваканция	Пролетна ваканция	Лятна ваканция
//момчета/момичета	9.60	7.20	15
//смесена група	10	9.50	20
//Училището получава отстъпка от крайната цена, в зависимост от броя на настанените в хотела ученици:
//•	Ако броят на учениците е 50 или повече, училището получава 50% отстъпка
//•	Ако броят на учениците е 20 или повече и в същото време по-малък от 50, училището получава 15% отстъпка
//•	Ако броят на учениците е 10 или повече и в същото време по-малък от 20, училището получава 5% отстъпка
//В таблицата по-долу са дадени спортовете, които ще се практикуват в зависимост от вида на ваканцията и групата:
//	Зимна ваканция	Пролетна ваканция	Лятна ваканция
//момичета	Gymnastics	Athletics	Volleyball
//момчета	Judo	Tennis	Football
//смесена група	Ski	Cycling	Swimming
//Да се напише програма, която пресмята цената, която ще заплати училището за нощувките и принтира спорта, който ще се практикува от учениците.
//Вход
//От конзолата се четат 4 реда:
//1.Сезонът – текст - “Winter”, “Spring” или “Summer”;
//2.Видът на групата – текст - “boys”, “girls” или “mixed”;
//3.Брой на учениците – цяло число в интервала [1 … 10000];
//4.Брой на нощувките – цяло число в интервала [1 … 100].
//Изход
//На конзолата се отпечатва 1 ред:
//•	Спортът, който са практикували учениците и цената за нощувките, която е заплатило училището,
//форматирана до втория знак след десетичната запетая, в следния формат:
//"{спортът} {цената} lv.“

using System;


class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        string type = Console.ReadLine();
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double price = 0;
        string sport = string.Empty;

        if (type == "boys")
        {
            switch (season)
            {
                case "Winter": price = 9.60; sport = "Judo"; break;
                case "Spring": price = 7.20; sport = "Tennis"; break;
                case "Summer": price = 15.00; sport = "Football"; break;
            }
        }
        else if (type == "girls")
        {
            switch (season)
            {
                case "Winter": price = 9.60; sport = "Gymnastics"; break;
                case "Spring": price = 7.20; sport = "Athletics"; break;
                case "Summer": price = 15.00; sport = "Volleyball"; break;
            }
        }

        else switch (season)
            {
                case "Winter": price = 10.00; sport = "Ski"; break;
                case "Spring": price = 9.50; sport = "Cycling"; break;
                case "Summer": price = 20.00; sport = "Swimming"; break;
            }

        double total = price * nights * students;

        if (students >= 50) total *= 0.50;
        else if (students >= 20) total *= 0.85;
        else if (students >= 10) total *= 0.95;

        Console.WriteLine($"{sport} {total:f2} lv.");
    }
}