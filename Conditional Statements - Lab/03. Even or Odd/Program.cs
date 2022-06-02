//Да се напише програма, която чете цяло число, въведено от потребителя, и печата дали е четно или нечетно. 
//Ако е четно отпечатайте "even", ако е нечетно "odd".

using System;

internal class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0) Console.WriteLine("even");
        else Console.WriteLine("odd");
    }
}
