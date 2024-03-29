﻿//Ани се страхува от това, да не й бъде хакнат някой от профилите в социалните мрежи,
//затова решава да направи генератор за пароли, които да бъдат достатъчно сигурни.
//Вашата задача е да й помогнете да напише програма, която ще генерира тези пароли, разделени една от друга от знака "|".
//Да се напише програма, която генерира серия от символи като в шаблона:
//ABxyBA
//като при всяко генериране на нов код, стойностите на символите се увеличават с 1.
//Ако A надхвърли 55, се връща на 35. Ако B надхвърли 96, се връща на 64.
//Вход
//От конзолата се чете 1 ред:
//•	На първия ред a – цяло число в интервала [1 … 1000]
//•	На втория ред b – цяло число в интервала [1 … 1000]
//•	На третия ред максимален брой генерирани пароли – цяло число в интервала [1 … 1000000]
//Ограничения:
//•	A е символ с ASCII стойност в диапазона [35… 55]
//•	B е символ с ASCII стойност в диапазона [64 … 96]
//•	x e цяло число в диапазона [1… a] 
//•	y e цяло число в диапазона [1… b]
//Изход:
//Да се отпечата на конзолата:
//•	Генерираният код.Ако броят на комбинациите е по-голям от максималния на кода,
//да се отпечата до подадената стойност, в противен случай да се отпечата до текущия брой на комбинациите.

using System;


class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int pass = int.Parse(Console.ReadLine());
        char A = Convert.ToChar(35);
        char B = Convert.ToChar(64);

        for (int x = 1; x <= a; x++)
        {
            for (int y = 1; y <= b; y++)
            {
                Console.Write($"{A}{B}{x}{y}{B}{A}|");
                A++; B++;
                if (A > 55) A = Convert.ToChar(35);
                if (B > 96) B = Convert.ToChar(64);
                pass--;
                if (pass == 0) return;
            }
        }

    }
}