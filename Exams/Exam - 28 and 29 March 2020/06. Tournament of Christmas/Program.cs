//Напишете програма, която проследява представянето на вашия отбор на благотворителен коледен турнир.
//Всеки ден получавате имена на игри до команда "Finish".
//Със спечелването на всяка една игра печелите по 20лв. за благотворителност.
//Трябва да изчислите колко пари сте спечелили на края на деня. Ако имате повече спечелени игри,
//отколкото загубени – вие сте победители този ден и увеличавате парите от него с 10%.
//При приключване на турнира ако през повечето дни сте били победители печелите турнира и увеличавате всичките спечелени пари с 20%.
//Никога няма да имате равен брой спечелени и загубени игри.
//Вход
//Първоначално от конзолата се прочита броя дни на турнира – цяло число в интервала [1… 20]
//До получаване на командата "Finish" се чете:
//•	Спорт  – текст
//За всеки спорт се прочита:
//o Резултат  – текст с възможности: "win" или "lose"
//Изход
//Накрая се отпечатва един ред:
//•	Ако сте спечелили турнира:
//     	"You won the tournament! Total raised money: {спечелените пари}"
//•	Ако сте загубили на турнира:
//"You lost the tournament! Total raised money: {спечелените пари}"
//Парите да бъдат форматирани до втората цифра след десетичния знак.

using System;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double totalMoney = 0;
        int dayScore = 0;

        for (int i = 1; i <= n; i++)
        {
            double dailyMoney = 0;
            int gameScore = 0;
            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string outcome = Console.ReadLine();
                if (outcome == "win")
                {
                    dailyMoney += 20;
                    gameScore++;
                }
                else gameScore--;

                input = Console.ReadLine();
            }

            if (gameScore > 0) { dailyMoney *= 1.1; dayScore++; }
            else dayScore--;
            totalMoney += dailyMoney;
        }

        if (dayScore > 0)
        {
            totalMoney *= 1.2;
            Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
        }
        else Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
    }
}