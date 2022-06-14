//Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на Фаренхайт (°F).
//Потърсете в Интернет подходяща формула, с която да извършите изчисленията.
//Форматирате изхода до втория знак след десетичната запетая. 

using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 1.8 + 32;
        Console.WriteLine($"{fahrenheit:f2}");
    }
}