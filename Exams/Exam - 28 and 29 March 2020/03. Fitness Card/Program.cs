//Да се напише програма, която проверява дали първоначално налична сума е достатъчна,
//за да се заплати карта за месечен достъп във фитнес.
//Цената на картата зависи от пола на клиента и спорта, който практикува:
//Пол Gym	Boxing	Yoga	Zumba	Dances	Pilates
//мъж	$42	$41	$45	$34	$51	$39
//жена	$35	$37	$42	$31	$53	$37

//Всички цени на карти за ученици (възраст под 19 години вкл.) са с 20% намаление.
//Вход
//От конзолата се прочитат 4 реда:
//•	Сумата, с която разполагаме - реално число в интервала [10.00…1000.00]
//•	Пол - символ('m' за мъж и 'f' за жена)
//•	Възраст - цяло число в интервала [5…105]
//•	Спорт - текст(една от възможностите в таблицата)
//Изход
//На конзолата се отпечатва 1 ред:
//•	Ако сумата е достатъчна:
//"You purchased a 1 month pass for {sport}."
//където
//{ sport}
//е въведения тип спорт
//•	Ако сумата не е достатъчна трябва да се пресметне колко още пари са необходими, за да се закупи карта:
//"You don't have enough money! You need ${money} more."
//където
//{ money}
//e оставащата сума нужна, за да се закупи картата, форматирана до втория знак след десетичната запетая.

using System;


public class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();
        double total = 0;

        switch (sport)
        {
            case "Gym":
                if (gender == 'm') total = 42.00;
                else total = 35.00;
                break;
            case "Boxing":
                if (gender == 'm') total = 41.00;
                else total = 37.00;
                break;
            case "Yoga":
                if (gender == 'm') total = 45.00;
                else total = 42.00;
                break;
            case "Zumba":
                if (gender == 'm') total = 34.00;
                else total = 31.00;
                break;
            case "Dances":
                if (gender == 'm') total = 51.00;
                else total = 53.00;
                break;
            case "Pilates":
                if (gender == 'm') total = 39.00;
                else total = 37.00;
                break;
        }
        if (age <= 19) total *= 0.8;

        if (budget >= total) Console.WriteLine($"You purchased a 1 month pass for {sport}.");
        else Console.WriteLine($"You don't have enough money! You need ${total - budget:f2} more.");
    }
}