//Да се напише програма, която чете от конзолата текст (име на човек) и отпечатва "Hello, <name>!", 
//където <name> е въведеното име от конзолата.

using System;


namespace Presentation
{
    internal class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
