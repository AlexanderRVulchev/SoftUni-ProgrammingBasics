//За Лора думите притежават голяма сила. Тя те моли да измислиш алгоритъм, с който да откриеш коя е "най-силната" дума.
//До получаване на команда "End of words" ще се четат от конзолата думи. За да се открие силата на всяка една,
//трябва да се намери сборът от ASCII стойностите на символите, от които се състои думата. Ако започва с гласна буква -
//'a', 'e', 'i', 'o', 'u', 'y' (или техните еквивалентни главни букви), полученият сбор трябва да се умножи по дължината на думата,
//в противен случай, да се раздели на дължината и да се закръгли до най-близкото цяло число надолу.
//Вход
//До получаване на команда "End of words" се чете по един ред от конзолата:
//•	дума – текст
//Изход
//След приключване на програмата се печата на един ред думата с "най-голяма сила":
//•	"The most powerful word is {думата с най-голяма сила} - {силата на думата}"

using System;


public class Program
{
    static void Main()
    {
        string bestWord = string.Empty;
        int bestValue = int.MinValue;
        string input = Console.ReadLine();

        while (input != "End of words")
        {
            int value = 0;
            for (int i = 0; i < input.Length; i++)
            {
                value += input[i];
            }
            if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u' || input[0] == 'y' ||
                input[0] == 'A' || input[0] == 'E' || input[0] == 'I' || input[0] == 'O' || input[0] == 'U' || input[0] == 'Y')
                value *= input.Length;
            else value /= input.Length;

            if (value > bestValue)
            {
                bestValue = value;
                bestWord = input;
            }
            input = Console.ReadLine();
        }

        Console.WriteLine($"The most powerful word is {bestWord} - {bestValue}");
    }
}