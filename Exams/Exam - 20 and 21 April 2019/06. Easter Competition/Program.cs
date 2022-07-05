//С наближаването на Великден, пекарна организира конкурс за направата на най-хубав козунак.
//Напишете програма, която да намира сладкаря с най-висок резултат.
//В началото на конкурса се въвежда броя на козунаците, които ще бъдат дегустирани от посетителите на пекарната,
//като за всеки козунак различен брой посетители, ще дадат оценка от 1 до 10.
//Вход
//Първоначално от конзолата се прочита броя на козунаците – цяло число в интервала [1… 100]
//След това за всеки козунак се прочита:
//•	Името на пекаря, който е направил козунака – текст
//•	До получаване на командата "Stop" се прочита 
//o	оценка за козунак от един човек  – цяло число в интервала [1... 10]
//Изход
//След получаване на командата "Stop" се печата един ред:
//•	"{името на пекаря} has {общият брой получени точки} points."
//Ако след командата "Stop", пекарят е с най-много точки до момента, да се отпечата допълнителен ред:
//•	"{името на пекаря} is the new number 1!"
//След дегустация на всички козунаци, да се отпечата един ред:
//•	"{името на пекаря с най-много точки} won competition with {точките на пекаря} points!"

using System;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string winnerName = string.Empty;
        int winnerPoints = 0;
        int pointsThisBaker = 0;

        for (int i = 1; i <= n; i++)
        {
            string name = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int points = int.Parse(input);
                pointsThisBaker += points;
                input = Console.ReadLine();
            }
            Console.WriteLine($"{name} has {pointsThisBaker} points.");
            if (pointsThisBaker > winnerPoints)
            {
                winnerPoints = pointsThisBaker;
                winnerName = name;
                Console.WriteLine($"{name} is the new number 1!");
            }
            pointsThisBaker = 0;
        }
        Console.WriteLine($"{winnerName} won competition with {winnerPoints} points!");
    }
}