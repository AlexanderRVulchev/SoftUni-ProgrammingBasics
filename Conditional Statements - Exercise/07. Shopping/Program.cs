//Петър иска да купи N видеокарти, M процесора и P на брой рам памет.
//Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка.
//Важат следните цени:
//•	Видеокарта – 250 лв./ бр.
//•	Процесор – 35 % от цената на закупените видеокарти/бр.
//•	Рам памет – 10% от цената на закупените видеокарти/бр.
//Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
//Вход
//Входът се състои от четири реда:
//1.Бюджетът на Петър - реално число в интервала [0.0…100000.0]
//2.Броят видеокарти - цяло число в интервала [0…100]
//3.Броят процесори - цяло число в интервала [0…100]
//4.Броят рам памет - цяло число в интервала [0…100]
//Изход
//На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
//•	Ако бюджета е достатъчен:
//"You have {остатъчен бюджет} leva left!"
//•	Ако сумата надхвърля бюджета:
//"Not enough money! You need {нужна сума} leva more!"
//Резултатът да се форматира до втория знак след десетичната запетая.

using System;

public class Program
{
    static void Main()
    {
        double bugetPetar = double.Parse(Console.ReadLine());
        int videoCards = int.Parse(Console.ReadLine());
        int proccesors = int.Parse(Console.ReadLine());
        int ram = int.Parse(Console.ReadLine());

        double praiceVideoCards = videoCards * 250;
        double praiceProccesors = (praiceVideoCards * 0.35) * proccesors;
        double praiceRam = (praiceVideoCards * 0.1) * ram;

        double totalSum = praiceVideoCards + praiceProccesors + praiceRam;

        if (videoCards > proccesors)
            totalSum -= totalSum * 0.15;
        if (totalSum <= bugetPetar)
            Console.WriteLine($"You have {bugetPetar - totalSum:f2} leva left!");
        else if (totalSum > bugetPetar)
            Console.WriteLine($"Not enough money! You need {totalSum - bugetPetar:f2} leva more!");
    }
}