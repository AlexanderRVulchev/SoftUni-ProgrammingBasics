//Ани намира кученце, за което ще се грижи, докато се намери някой да го осинови.
//То изяжда дневно определено количество храна.
//Да се напише програма, която проверява дали количеството храна, което е закупено за кученцето,
//ще е достатъчно докато кученцето бъде осиновено.
//Вход
//От конзолата се прочитат:
//•	Закупеното количество храна за кученцето в килограми – цяло число в интервала [1 …100]
//•	На всеки следващ ред до получаване на команда Adopted ще получавате колко грама изяжда кученцето на всяко хранене -
//цяло число в интервала [10 …1000]
//Изход
//На конзолата се отпечатва 1 ред:
//•	Ако количеството храна е достатъчно да се отпечата:
// 	"Food is enough! Leftovers: {останала храна} grams."
//•	Ако количеството храна не е достатъчно да се отпечата:
// 	"Food is not enough. You need {нужно количество храна} grams more."

using System;


public class Program
{
    static void Main()
    {
        int allFood = int.Parse(Console.ReadLine()) * 1000;
        string input = Console.ReadLine();

        while (input != "Adopted")
        {
            int food = int.Parse(input);
            allFood -= food;
            input = Console.ReadLine();
        }
        if (allFood >= 0) Console.WriteLine($"Food is enough! Leftovers: {allFood} grams.");
        else Console.WriteLine($"Food is not enough. You need {Math.Abs(allFood)} grams more.");
    }
}