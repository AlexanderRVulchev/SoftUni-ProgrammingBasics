//Мария иска да купи подарък на сина си.
//Тя работи в магазин за цветя. В магазина идва поръчка за цветя. Напишете програма, която пресмята сумата от поръчката и дали печалбата е достатъчна за подаръка.
//Цветята имат следните цени:

//•	Магнолии – 3.25 лева
//•	Зюмбюли – 4 лева
//•	Рози – 3.50 лева
//•	Кактуси – 8 лева
//От общата сума, Мария трябва да плати 5% данъци. 

//Вход
//Входът се чете от конзолата и се състои от 5 реда:
//•	Брой магнолии – цяло число в интервала [0 … 50]
//•	Брой зюмбюли – цяло число в интервала [0 … 50]
//•	Брой рози – цяло число в интервала [0 … 50]
//•	Брой кактуси – цяло число в интервала [0 … 50]
//•	Цена на подаръка – реално число в интервала [0.00 … 500.00]
//Изход
//На конзолата трябва да се отпечата един ред.
//•	Ако парите СА стигнали: "She is left with {останали} leva." –
//сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1).
//•	Ако парите НЕ достигат: "She will have to borrow {останали} leva." –
//сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2).

using System;

class Program
{
    static void Main(string[] args)
    {
        double magnolia = double.Parse(Console.ReadLine()) * 3.25;
        double zumbul = double.Parse(Console.ReadLine()) * 4.00;
        double rose = double.Parse(Console.ReadLine()) * 3.50;
        double cactus = double.Parse(Console.ReadLine()) * 8.00;
        double presentPrice = double.Parse(Console.ReadLine());

        double earnings = magnolia + zumbul + rose + cactus;
        earnings *= 0.95;
        if (earnings >= presentPrice) Console.WriteLine($"She is left with {Math.Floor(earnings - presentPrice)} leva.");
        else Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - earnings)} leva.");
    }
}