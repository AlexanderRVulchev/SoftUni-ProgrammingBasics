//Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
//"{първи множител} * {втори множител} = {резултат}".

using System;


internal class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = { i * j }");
            }
        }
    }
}