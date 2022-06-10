//Дадени са n цели числа в интервала [1…1000]. От тях някакъв процент p1 са под 200, друг процент p2 са от 200 до 399,
//друг процент p3 са от 400 до 599, друг процент p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре.
//Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.

using System;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;


        for (int i = 1; i <= n; i++)
        {
            count++;
            int num = int.Parse(Console.ReadLine());
            if (num < 200) p1++;
            else if (num < 400) p2++;
            else if (num < 600) p3++;
            else if (num < 800) p4++;
            else p5++;
        }
        Console.WriteLine("{0:f2}%", p1 * 100.0 / count);
        Console.WriteLine("{0:f2}%", p2 * 100.0 / count);
        Console.WriteLine("{0:f2}%", p3 * 100.0 / count);
        Console.WriteLine("{0:f2}%", p4 * 100.0 / count);
        Console.WriteLine("{0:f2}%", p5 * 100.0 / count);
    }
}