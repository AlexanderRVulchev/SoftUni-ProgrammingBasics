//Напишете програма, която чете цяло число, въведено от потребителя, и отпечатва ден от седмицата (на английски език), в граници[1...7]
//или отпечатва "Error" в случай, че въведеното число е невалидно. 

using System;

public class Program
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}