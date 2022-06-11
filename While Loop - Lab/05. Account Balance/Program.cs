//Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски.
//На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" .
//При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката.
//Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи.
//Когато п*/рограмата приключи трябва да се принтира "Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 

using System;

internal class Program
{
    static void Main()
    {
        string input;
        double total = 0;

        while (true)
        {
            double deposit;
            input = Console.ReadLine();
            if (input == "NoMoreMoney") break;
            else deposit = double.Parse(input);
            if (deposit < 0)
            {
                Console.WriteLine("Invalid operation!"); break;
            }
            Console.WriteLine($"Increase: {deposit:F2}");
            total += deposit;
        }
        Console.WriteLine($"Total: {total:F2}");
    }
}