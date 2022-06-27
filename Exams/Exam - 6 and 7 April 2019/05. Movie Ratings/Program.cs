//Деси много обича да гледа филми, но често й е трудно да си избере подходящ за гледане.
//Набелязва си определен брой филми и иска да си избере кой филм да гледа спрямо рейтинга на филмите.
//Напишете програма, която показва кой филм е с най-висок рейтинг,
//кой е с най-нисък и колко е средният рейтинг от всички филми, които си е набелязала да гледа.
//Вход
//От конзолата първо се чете един ред:
//•	Брой филми, които си е набелязала Деси – цяло число в интервала [1…20]
//За всеки филм се прочитат два отделни реда:
//•	Име на филма – текст 
//•	Рейтинг на филма - реално число в интервала [1.00…10.00]
//Изход
//Отпечатват се три реда в следния формат:
//•	"{име на филма с най-висок рейтинг} is with highest rating: {рейтинг на филма}"
//•	"{име на филма с най-нисък рейтинг} is with lowest rating: {рейтинг на филма}"
//•	"Average rating: {средният рейтинг на всички филми}"
//Максималният, минималният и средният рейтинг да се форматира до първата цифра след десетичния знак.

using System;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string highestName = "";
        double highestRating = double.MinValue;
        string lowestName = "";
        double lowestRating = double.MaxValue;
        double sumRating = 0;

        for (int i = 1; i <= n; i++)
        {
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            if (rating > highestRating)
            {
                highestRating = rating;
                highestName = name;
            }
            if (rating < lowestRating)
            {
                lowestRating = rating;
                lowestName = name;
            }
            sumRating += rating;
        }

        Console.WriteLine($"{highestName} is with highest rating: {highestRating:f1}");
        Console.WriteLine($"{lowestName} is with lowest rating: {lowestRating:f1}");
        Console.WriteLine($"Average rating: {sumRating / n:f1}");
    }
}