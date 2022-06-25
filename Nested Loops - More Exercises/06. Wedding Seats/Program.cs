//Младоженците искат да направят списък кой на кое място ще седи на сватбената церемония.
//Местата са разделени на различни сектори. Секторите са главните латински букви като започват от A.
//Във всеки сектор има определен брой редове. От конзолата се чете броят на редовете в първия сектор (A),
//като във всеки следващ сектор редовете се увеличават с 1.
//На всеки ред има определен брой места - тяхната номерация е представена с малките латински букви.
//Броя на местата на нечетните редове се прочита от конзолата, а на четните редове местата са с 2 повече.
//Вход
//От конзолата се четaт 3 реда:
//•	Последния сектор от секторите - символ (B-Z)
//•	Броят на редовете в първия сектор - цяло число (1-100)
//•	Броят на местата на нечетен ред - цяло число (1-24)
//Изход
//Да се отпечата на конзолата всяко място на отделен ред по следния формат:
//{ сектор}
//{ ред}
//{ място}
//Накрая трябва да отпечата броя на всички места.

using System;

class Program
{
    static void Main()
    {
        char lastSector = char.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int seatsOdd = int.Parse(Console.ReadLine());
        int totalSeats = 0;

        for (char currSector = 'A'; currSector <= lastSector; currSector++)
        {
            for (int currRow = 1; currRow <= rows; currRow++)
            {
                int seats = seatsOdd;
                if (currRow % 2 == 0) seats += 2;
                for (char currSeat = 'a'; currSeat < 'a' + seats; currSeat++)
                {
                    Console.WriteLine($"{currSector}{currRow}{currSeat}");
                    totalSeats++;
                }
            }
            rows++;
        }
        Console.WriteLine(totalSeats);
    }
}