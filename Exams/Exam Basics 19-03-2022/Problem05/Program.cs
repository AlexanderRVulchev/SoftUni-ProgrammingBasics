using System;


namespace Problem05
{
    internal class Program
    {
        static void Main()
        {
            int sea = int.Parse(Console.ReadLine());
            int mountain = int.Parse(Console.ReadLine());
            int profit = 0;

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                if (input == "sea" && sea > 0) { sea--; profit += 680; }
                if (input == "mountain" && mountain > 0) { mountain--; profit += 499; }
                if (sea == 0 && mountain == 0) { Console.WriteLine("Good job! Everything is sold."); break; }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
