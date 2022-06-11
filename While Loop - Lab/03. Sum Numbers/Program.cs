//Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното число.
//След приключване да се отпечата сумата на въведените числа.

using System;

internal class Program
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());
        int sum = 0;

        while (sum < limit)
        {
            int newNum = int.Parse(Console.ReadLine());
            sum += newNum;
        }
        Console.WriteLine(sum);
    }
}