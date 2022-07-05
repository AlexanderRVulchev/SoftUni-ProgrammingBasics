//Предстои Великден и едно от най-вълнуващите неща е боядисването на яйца. Наличните цветове за боядисване са:
//•	червено(red)
//•	оранжев(orange)
//•	син(blue)
//•	зелен(green)
//Напишете програма, която изчислява какъв е броят на яйцата от всеки цвят и от кой цвят яйцата са
//най - много, като знаете общия им брой и цвета на всяко яйце.
//Вход
//От конзолата се чете 1 ред:
//•	 Броят на боядисаните яйца – цяло число в интервала [1 ... 100]
//За всяко яйце се чете:
//o Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"
//Изход
//Да се отпечатат на конзолата 5 реда:
//•	"Red eggs: {брой на червените яйца}"
//•	"Orange eggs: {брой на оранжевите яйца}"
//•	"Blue eggs: {брой на сините яйца}"
//•	"Green eggs: {брой на зелените яйца}"
//•	"Max eggs: {максимален брой на яйцата от цвят} -> {цвят}"

using System;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int red = 0;
        int orange = 0;
        int blue = 0;
        int green = 0;

        for (int i = 1; i <= n; i++)
        {
            string eggType = Console.ReadLine();
            switch (eggType)
            {
                case "red": red++; break;
                case "orange": orange++; break;
                case "blue": blue++; break;
                case "green": green++; break;
            }
        }
        Console.WriteLine($"Red eggs: {red}");
        Console.WriteLine($"Orange eggs: {orange}");
        Console.WriteLine($"Blue eggs: {blue}");
        Console.WriteLine($"Green eggs: {green}");
        int max = Math.Max(Math.Max(red, orange), Math.Max(blue, green));
        Console.Write($"Max eggs: {max} -> ");
        if (max == red) Console.WriteLine("red");
        else if (max == orange) Console.WriteLine("orange");
        else if (max == blue) Console.WriteLine("blue");
        else if (max == green) Console.WriteLine("green");
    }
}