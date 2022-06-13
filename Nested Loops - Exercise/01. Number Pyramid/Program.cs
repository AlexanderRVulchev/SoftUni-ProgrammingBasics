//Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа 

using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        bool ending = false;

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{count++} ");
                if (count > n)
                {
                    ending = true;
                    break;
                }
            }
            Console.WriteLine();
            if (ending) break;
        }
    }
}
