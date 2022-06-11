//Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях.
//Въвежда се по едно число на ред. 

using System;

internal class Program
{
    static void Main()
    {
        int min = int.MaxValue;
        string input;

        while (true)
        {
            int num;
            input = Console.ReadLine();
            if (input == "Stop") break;
            else
            {
                num = int.Parse(input);
                min = Math.Min(min, num);
            }
        }
        Console.WriteLine(min);
    }
}