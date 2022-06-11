//Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, ….
//Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.

using System;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        while (num <= n)
        {
            Console.WriteLine(num);
            num = num * 2 + 1;
        }
    }
}