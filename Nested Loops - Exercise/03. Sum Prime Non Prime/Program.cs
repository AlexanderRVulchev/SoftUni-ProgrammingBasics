//Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop".
//Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа.
//Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости, ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.".
//В този случай въведено число се игнорира и не се прибавя към нито една от двете суми, а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
//На изхода да се отпечатат на два реда двете намерени суми в следния формат:
//•	"Sum of all prime numbers is: {prime numbers sum}"
//•	"Sum of all non prime numbers is: {nonprime numbers sum}"

using System;


internal class Program
{
    static void Main()
    {
        int prime = 0;
        int nonprime = 0;
        string input = Console.ReadLine();

        while (input != "stop")
        {
            bool isItPrime = true;
            int num = int.Parse(input);
            if (num < 0) Console.WriteLine("Number is negative.");
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0) isItPrime = false;
                }
                if (isItPrime) prime += num;
                else nonprime += num;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Sum of all prime numbers is: {prime}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonprime}");
    }
}