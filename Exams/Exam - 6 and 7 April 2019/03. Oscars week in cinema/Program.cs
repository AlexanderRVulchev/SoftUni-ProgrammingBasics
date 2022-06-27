//По време на седмицата на Оскарите, градското кино пуска прожекции на някои от филмите, които са номинирани в категорията за "Най-добър филм".
//В таблицата са показани кои са филмите и каква е цената за прожекция спрямо залата, в която се прожектира филмът. 
//Филм	normal	luxury	ultra luxury
//A Star Is Born	7.50 лв.	10.50 лв.	13.50 лв.
//Bohemian Rhapsody	7.35 лв.	9.45 лв.	12.75 лв.
//Green Book	8.15 лв.	10.25 лв.	13.25 лв.
//The Favourite	8.75 лв.	11.55 лв.	13.95 лв.
//Напишете програма, която изчислява какъв е приходът от даден филм,
//като знаете в какъв тип зала се прожектира и колко човека са си купили билет за прожекцията.
//Вход
//Входът се чете от конзолата и се състои от три реда:
//•	Първи ред – име на филм – текст ("A Star Is Born", "Bohemian Rhapsody","Green Book" или "The Favourite")
//•	Втори ред– вид на залата – текст ("normal", "luxury" или "ultra luxury")
//•	Трети ред – брой на закупените билети – цяло число в интервала [1…100]
//Изход
//На конзолата трябва да се отпечата един ред:
//"{име на филма} -> {приходи от прожекцията на филма} lv."
//Приходите да бъдат закръглени до втория знак след десетичната запетая.

using System;


public class Program
{
    static void Main()
    {
        string movie = Console.ReadLine();
        string type = Console.ReadLine();
        int tickets = int.Parse(Console.ReadLine());
        double price = 0;

        if (type == "normal")
        {
            switch (movie)
            {
                case "A Star Is Born": price = 7.50; break;
                case "Bohemian Rhapsody": price = 7.35; break;
                case "Green Book": price = 8.15; break;
                case "The Favourite": price = 8.75; break;
            }
        }
        else if (type == "luxury")
        {
            switch (movie)
            {
                case "A Star Is Born": price = 10.50; break;
                case "Bohemian Rhapsody": price = 9.45; break;
                case "Green Book": price = 10.25; break;
                case "The Favourite": price = 11.55; break;
            }

        }
        else if (type == "ultra luxury")
        {
            switch (movie)
            {
                case "A Star Is Born": price = 13.50; break;
                case "Bohemian Rhapsody": price = 12.75; break;
                case "Green Book": price = 13.25; break;
                case "The Favourite": price = 13.95; break;
            }
        }

        double total = price * tickets;
        Console.WriteLine($"{movie} -> {total:f2} lv.");
    }
}