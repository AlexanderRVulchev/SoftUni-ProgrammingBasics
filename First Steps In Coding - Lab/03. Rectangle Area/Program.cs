//Да се напише конзолна програма, която въвежда две цели числа (страните на правоъгълника a и b) и пресмята лицето на правоъгълник с тези страни.

using System;

namespace Presentation
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
    }
}
