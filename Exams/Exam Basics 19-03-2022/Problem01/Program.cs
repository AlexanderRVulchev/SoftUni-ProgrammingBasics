using System;

namespace Problem01
{
    internal class Program
    {
        static void Main()
        {            
            double processor = double.Parse(Console.ReadLine()) * 1.57;
            double videoCard = double.Parse(Console.ReadLine()) * 1.57;
            double ram = double.Parse(Console.ReadLine()) * 1.57;
            int ramAmount = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            processor -= processor * discount;
            videoCard -= videoCard * discount;
            ram *= ramAmount;
            double total = processor + videoCard + ram;

            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
