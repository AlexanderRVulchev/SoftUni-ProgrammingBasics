//Напишете програма, която прочита едно число n, след това прочита n на брой цели числа
//и принтира средно аритметичното на тяхната сума число, форматирано до втората цифра след десетични знак.

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0:f2}", (double)sum / n);
    }
}