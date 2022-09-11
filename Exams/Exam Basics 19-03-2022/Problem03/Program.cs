using System;


namespace Problem03
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double total = 0;
            switch (season)
            {
                case "spring":
                    if (people <= 5) total = people * 50.00;
                    else total = people * 48.00;
                    break;
                case "summer":
                    if (people <= 5) total = people * 48.50;
                    else total = people * 45.00;
                    total -= 0.15 * total;
                    break;
                case "autumn":
                    if (people <= 5) total = people * 60.00;
                    else total = people * 49.50;
                    break;
                case "winter":
                    if (people <= 5) total = people * 86.00;
                    else total = people * 85.00;
                    total += 0.08 * total;
                    break;                
            }
            Console.WriteLine($"{total:f2} leva.");
        }
    }
}
