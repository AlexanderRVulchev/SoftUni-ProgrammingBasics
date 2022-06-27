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


public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int student = 0;
        int standard = 0;
        int kid = 0;

        while (input != "Finish")
        {
            int seats = int.Parse(Console.ReadLine());
            int seatstaken = 0;
            for (int i = 0; i < seats; i++)
            {
                bool isEnd = false;
                string type = Console.ReadLine();
                switch (type)
                {
                    case "student":
                        student++; seatstaken++;
                        break;
                    case "standard":
                        standard++; seatstaken++;
                        break;
                    case "kid":
                        kid++; seatstaken++;
                        break;
                    case "End": isEnd = true; break;
                }
                if (isEnd) break;
            }
            Console.WriteLine($"{input} - {seatstaken * 100.0 / seats:f2}% full.");
            input = Console.ReadLine();
        }

        int allTickets = student + standard + kid;
        Console.WriteLine($"Total tickets: {allTickets}");
        Console.WriteLine($"{student * 100.0 / allTickets:f2}% student tickets.");
        Console.WriteLine($"{standard * 100.0 / allTickets:f2}% standard tickets.");
        Console.WriteLine($"{kid * 100.0 / allTickets:f2}% kids tickets.");
    }
}