//Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети:
//студентски(student), стандартен(standard) и детски(kid), за всички прожекции. Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
//Вход
//Входът е поредица от цели числа и текст:
//•	На първия ред до получаване на командата "Finish" - име на филма – текст
//•	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
//•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
//o Типа на закупения билет - текст ("student", "standard", "kid")
//Изход
//На конзолата трябва да се печатат следните редове:
//•	След всеки филм да се отпечата, колко процента от кино залата е пълна
//"{името на филма} - {процент запълненост на залата}% full."
//•	При получаване на командата "Finish" да се отпечатат четири реда:
//o "Total tickets: {общият брой закупени билети за всички филми}"
//o "{процент на студентските билети}% student tickets."
//o "{процент на стандартните билети}% standard tickets."
//o "{процент на детските билети}% kids tickets."

using System;


internal class Program
{
    static void Main()
    {
        int student = 0;
        int standard = 0;
        int kid = 0;
        int totalTickets = 0;

        string input = Console.ReadLine();
        while (input != "Finish")
        {
            int maxSeatsThisMovie = int.Parse(Console.ReadLine());
            int seats = 0;
            string type = Console.ReadLine();
            while (type != "End")
            {
                if (type == "student") student++;
                if (type == "standard") standard++;
                if (type == "kid") kid++;
                seats++;
                totalTickets++;
                if (seats == maxSeatsThisMovie) break;
                type = Console.ReadLine();
            }
            Console.WriteLine($"{input} - {(seats * 100.0 / maxSeatsThisMovie):f2}% full.");
            input = Console.ReadLine();
        }
        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{(student * 100.0 / totalTickets):f2}% student tickets.");
        Console.WriteLine($"{(standard * 100.0 / totalTickets):f2}% standard tickets.");
        Console.WriteLine($"{(kid * 100.0 / totalTickets):f2}% kids tickets.");
    }
}