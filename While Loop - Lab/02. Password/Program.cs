//Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
//•	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
//•	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

using System;

internal class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        string pass = Console.ReadLine();
        string attempt = string.Empty;

        while (attempt != pass)
        {
            attempt = Console.ReadLine();
        }
        Console.WriteLine($"Welcome {name}!");
    }
}