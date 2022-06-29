//Иван е измислил нова игра в която да се състезава със своите приятели.
//Вашата задача е да напишете програма за играта. Всеки играч написва името си,
//след това за всяка една буква от името си написва по едно цяло число, ако числото съвпада с ASCII стойността на съответната буква,
//играчът получава 10 точки, в противен случай, получава само 2 точки.
//Победител е играчът с най-много точки в края на играта. В случай, че двама играчи имат равен брой точки, печели този, който втори е достигнал резултата.
//Вход
//До получаване на командата "Stop" се чете по един ред:
//•	Име на играча с дължина n - текст
//За всеки играч се четат n на брой реда:
//•	число – цяло число в интервала[0…127]
//Изход
//Да се отпечата един ред в следния формат:
//•	"The winner is {името на победителя} with {точките на победителя} points!"

using System;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int highScore = int.MinValue;
        string highName = "";

        while (input != "Stop")
        {
            int score = 0;
            for (int i = 0; i < input.Length; i++)
            {

                int num = int.Parse(Console.ReadLine());
                if (num == input[i]) score += 10;
                else score += 2;
            }
            if (score >= highScore)
            {
                highScore = score;
                highName = input;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"The winner is {highName} with {highScore} points!");
    }
}