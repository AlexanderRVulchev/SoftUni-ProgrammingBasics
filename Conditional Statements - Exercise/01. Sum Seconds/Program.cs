//Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50).
//Да се напише програма, която чете времената на състезателите в секунди, въведени от потребителя и пресмята сумарното им време във формат "минути:секунди".
//Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35"). 

using System;


namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int minutes = sum / 60;
            int seconds = sum % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}