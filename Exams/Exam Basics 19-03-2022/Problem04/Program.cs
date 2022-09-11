using System;


namespace Problem04
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double totalRating = 0;
            double totalSales = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int rating = num % 10;
                totalRating += rating;
                int possibleSales = num / 10;
                                
                switch (rating)
                {                    
                    case 3: totalSales += 0.50 * (double)possibleSales; break;
                    case 4: totalSales += 0.70 * (double)possibleSales; break;
                    case 5: totalSales += 0.85 * (double)possibleSales; break;
                    case 6: totalSales += 1.00 * (double)possibleSales; break;                    
                }

            }
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{totalRating / n:f2}");
        }
    }
}
