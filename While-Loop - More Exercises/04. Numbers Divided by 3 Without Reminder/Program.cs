//Напишете програма, която печата всички числа в интервала от 1 до 100, който се делят на 3 без остатък, по едно на ред.

using System;


class Program
{
    static void Main(string[] args)
    {
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
