//Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата следното съобщение: 
//"You are <firstName> <lastName>, a <age>-years old person from <town>."

using System;

namespace Presentation
{
    internal class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
