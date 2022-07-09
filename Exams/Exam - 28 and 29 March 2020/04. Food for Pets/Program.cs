//Ани има два домашни любимеца - куче и котка. Напишете програма,
//която изготвя статистика за храната на домашните любимци за определен брой дни.
//Всеки ден кучето и котката изяждат различно количество от общата им храна.
//На всеки трети ден получават награда - бисквитки. Количеството на бисквитките е 10% от общо изядената храна за деня.
//Вашата програма трябва да отпечатва статистика за количеството бисквитки, които са изяли,
//колко процента от първоначалното количество обща храна са изяли и колко процента от изядената храна е изяло кучето и колко е изяла котката.
//Вход
//Първоначално се чете един ред:
//•	Брой дни – цяло число в диапазона [1…30]
//•	Общо количество храна – реално число в диапазона [0.00…10000.00]
//След това за всеки ден се чете:
//o Количество изядена храна от кучето – цяло число в диапазона [10…500]
//o Количество изядена храна от котката – цяло число в диапазона [10…500]
//Изход
//На конзолата да се отпечатват четири реда:
//•	"Total eaten biscuits: {количество изядени бисквитки}gr."
//•	"{процент изядена храна}% of the food has been eaten."
//•	"{процент изядена храна от кучето}% eaten from the dog."
//•	"{процент изядена храна от котката}% eaten from the cat."
//Количеството изядени бисквитки трябва да бъде закръглено до най – близкото цяло число,
//а процентът храна трябва да бъде форматиран до втората цифра след десетичния знак.

using System;



public class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double allFood = double.Parse(Console.ReadLine());
        double catTotal = 0;
        double dogTotal = 0;
        double biscuits = 0;

        for (int i = 1; i <= days; i++)
        {
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            if (i % 3 == 0) biscuits += 0.1 * (dog + cat);
            catTotal += cat;
            dogTotal += dog;
        }

        double foodTotal = dogTotal + catTotal;
        Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
        Console.WriteLine($"{foodTotal * 100 / allFood:f2}% of the food has been eaten.");
        Console.WriteLine($"{dogTotal * 100 / foodTotal:f2}% eaten from the dog.");
        Console.WriteLine($"{catTotal * 100 / foodTotal:f2}% eaten from the cat.");
    }
}