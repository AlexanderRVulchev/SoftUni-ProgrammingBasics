//Напишете програма, която познава дали резервоара на едно превозно средство има нужда от презареждане на горивото или не.
//От конзолата се четат два реда – текст и реално число, на първия ред се чете типа на горивото – текст с възможности:
//"Diesel", "Gasoline" или "Gas", а на втория литрите гориво, които има в резервоара.
//Ако литрите гориво са повече или равни на 25, на конзолата да се отпечата "You have enough {вида на горивото}.",
//ако са по-малко от 25, да се отпечата "Fill your tank with {вида на горивото}!".
//В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".

using System;

class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        double liters = double.Parse(Console.ReadLine());
        if (type != "gas" && type != "gasoline" && type != "diesel") Console.WriteLine("Invalid fuel!");
        else
        {
            if (liters >= 25) Console.WriteLine($"You have enough {type}.");
            else Console.WriteLine($"Fill your tank with {type}!");
        }
    }
}