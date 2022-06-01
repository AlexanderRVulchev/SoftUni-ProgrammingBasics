//За лятната ваканция в списъка със задължителна литература на Жоро има определен брой книги.
//Понеже Жоро предпочита да играе с приятели навън, вашата задача е да му помогнете
//да изчисли колко часа на ден трябва да отделя, за да прочете необходимата литература.

using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int pagesPerDay = pagesInBook / days;
            int hoursPerDay = pagesPerDay / pagesPerHour;

            Console.WriteLine(hoursPerDay);
        }
    }
}