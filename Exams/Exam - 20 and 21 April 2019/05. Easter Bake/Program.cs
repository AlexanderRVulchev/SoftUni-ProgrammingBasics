//Предстои Великден и Деси е решила да изпече домашни козунаци за колегите си.
//Главните продукти, които ще трябват на Деси са: брашно и захар. Един пакет захар е 950 грама, а един пакет брашно е 750 грама.
//Напишете програма, която изчислява колко пакета захар и брашно трябва да купи Деси, за да й стигнат за направата на козунаците,
//като знаете за всеки един козунак по колко грама захар и брашно са изразходени.
//Също намерете кое е най-голямото количество захар и брашно, които са използвани.
//Вход
//От конзолата се чете 1 ред:
//•	 Броят на козунаците – цяло число в интервала [1 ... 100]
//За всеки козунак се чете:
//o Количество изразходвана захар (грамове) – цяло число в интервала [1 … 10000]
//o Количество изразходвано брашно (грамове) – цяло число в интервала [1 … 10000]
//Изход
//Да се отпечатат на конзолата 3 реда:
//•	"Sugar: {брой нужни пакети захар}"
//•	"Flour: {брой нужни пакет брашно}"
//•	"Max used flour is {максимално количество грамове брашно, използвани за правенето на козунак} grams,
//max used sugar is {максимално количество грамове захар, използвани за правенето на козунак} grams."
//Пакетите захар и брашно да бъдат закръглени към най-близкото цяло число нагоре.

using System;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sugarTotal = 0;
        int flourTotal = 0;
        int sugarMax = 0;
        int flourMax = 0;

        for (int i = 1; i <= n; i++)
        {
            int sugar = int.Parse(Console.ReadLine());
            int flour = int.Parse(Console.ReadLine());
            sugarTotal += sugar;
            flourTotal += flour;
            sugarMax = Math.Max(sugar, sugarMax);
            flourMax = Math.Max(flour, flourMax);
        }

        int sugarPacks = sugarTotal / 950;
        if (sugarTotal % 950 != 0) sugarPacks++;
        int flourPacks = flourTotal / 750;
        if (flourTotal % 750 != 0) flourPacks++;

        Console.WriteLine($"Sugar: {sugarPacks}");
        Console.WriteLine($"Flour: {flourPacks}");
        Console.WriteLine($"Max used flour is {flourMax} grams, max used sugar is {sugarMax} grams.");
    }
}