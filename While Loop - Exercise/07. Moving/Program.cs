//На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира.
//Опаковал багажа си в кашони и намерил подходяща обява за апартамент под наем.
//Той започва да пренася своя багаж на части, защото не може да пренесе целия наведнъж.
//Има ограничено свободно пространство в новото си жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.
//Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си. 
//Бележка: Един кашон е с точни размери:  1m.x 1m.x 1m.

using System;

internal class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int space = x * y * z;

        while (true)
        {
            if (space < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                break;
            }
            string input = Console.ReadLine();
            if (input == "Done")
            {
                Console.WriteLine($"{space} Cubic meters left.");
                break;
            }
            int boxes = int.Parse(input);
            space -= boxes;
        }
    }
}