//Напишете програма, която отпечатва часовете в денонощието от 0:0 до 23:59, всеки на отделен ред.
//Часовете трябва да се изписват във формат "{час}:{минути}".

using System;


internal class Program
{
    static void Main()
    {
        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 60; j++)
            {
                Console.WriteLine($"{i}:{j}");
            }
        }
    }
}
