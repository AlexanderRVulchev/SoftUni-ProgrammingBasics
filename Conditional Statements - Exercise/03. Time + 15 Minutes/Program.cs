//Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути.
//Резултатът да се отпечата във формат часове:минути.Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59.
//Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 

using System;

internal class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;
        if (minutes >= 60)
        {
            hours += 1; minutes -= 60;
        }
        if (hours >= 24) hours -= 24;

        if (minutes < 10) Console.WriteLine($"{hours}:0{minutes}");
        else Console.WriteLine($"{hours}:{minutes}");
    }
}
