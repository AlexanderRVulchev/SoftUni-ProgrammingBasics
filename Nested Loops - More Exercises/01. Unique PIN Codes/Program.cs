﻿//Да се напише програма, която генерира трицифрени PIN кодове, като цифрите на всеки PIN код са в определен интервал.
//За да бъде валиден един PIN код той трябва да отговаря на следните условия:
//•	Първата и третата цифра трябва да бъдат четни.
//•	Втората цифра трябва да бъде просто число в диапазона [2...7].
//Вход
//От конзолата се четат 3 реда:
//•	Горната граница на първото число - цяло число в диапазона [1...9]
//•	Горната граница на второто число - цяло число в диапазона [1...9]
//•	Горната граница на третото число - цяло число в диапазона [1...9]
//Изход
//Да се отпечатат на конзолата всички валидни трицифрени PIN кодове, чиито цифри отговарят на съответните интервали.

using System;


class Program
{
    static void Main(string[] args)
    {
        int firstTop = int.Parse(Console.ReadLine());
        int secondTop = int.Parse(Console.ReadLine());
        int thirdTop = int.Parse(Console.ReadLine());
        for (int n1 = 1; n1 <= firstTop; n1++)
        {
            for (int n2 = 1; n2 <= secondTop; n2++)
            {
                for (int n3 = 1; n3 <= thirdTop; n3++)
                {
                    if (n1 % 2 == 0 && n3 % 2 == 0)
                        switch (n2)
                        {
                            case 2:
                            case 3:
                            case 5:
                            case 7:
                                Console.WriteLine($"{n1} {n2} {n3}");
                                break;
                        }
                }

            }
        }
    }
}