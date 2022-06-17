//От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.
//От 1 кв.м лозе се изкарват Y килограма грозде. За 1 литър вино са нужни 2,5 кг. грозде.
//Желаното количество вино за продан е Z литра.
//Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.
//Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.
//Вход
//Входът се чете от конзолата и се състои от точно 4 реда:
//•	1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000]
//•	2ри ред: Y грозде за един кв.м – реално число в интервала [0.00 … 10.00]
//•	3ти ред: Z нужни литри вино – цяло число в интервала [10 … 600]
//•	4ти ред: брой работници – цяло число в интервала [1 … 20]
//Изход
//На конзолата трябва да се отпечата следното:
//•	Ако произведеното вино е по-малко от нужното:
//o   “It will be a tough winter! More { недостигащо вино}
//liters wine needed.”
//	Резултатът трябва да е закръглен към по-ниско цяло число
//•	Ако произведеното вино е колкото или повече от нужното:
//o	“Good harvest this year! Total wine: { общо вино}
//liters.”
//	Резултатът трябва да е закръглен към по-ниско цяло число
//o	“{Оставащо вино} liters left -> {вино за 1 работник} liters per person.”
//	И двата резултата трябва да са закръглени към по-високото цяло число

using System;

class Program
{
    static void Main(string[] args)
    {
        int vineArea = int.Parse(Console.ReadLine());
        double grapesPerSqM = double.Parse(Console.ReadLine());
        int wineNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double harvest = 0.4 * vineArea;
        double grapes = harvest * grapesPerSqM;
        double wine = grapes / 2.5;

        if (wine < wineNeeded) Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wine)} liters wine needed.");
        else
        {
            Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
            Console.WriteLine($"{Math.Ceiling(wine - wineNeeded)} liters left -> {Math.Ceiling((wine - wineNeeded) / workers)} liters per person.");
        }
    }
}