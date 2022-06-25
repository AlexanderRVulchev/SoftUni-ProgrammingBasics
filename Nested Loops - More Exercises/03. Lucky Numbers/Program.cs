﻿//Да се напише програма, която прочита едно цяло число N и генерира всички възможни "щастливи" и различни 4-цифрени числа(всяка цифра от числото е в интервала [1...9]). 
//Числото трябва да отговаря на следните условия: 
//Щастливо число е 4-цифрено число, на което сбора от първите две цифри е равен на сбора от последните две.
//Числото N трябва да се дели без остатък от сбора на първите две цифри на "щастливото" число.
//Вход
//Входът се чете от конзолата и се състои от едно цяло число в интервала [2...10000]
//Изход
//На конзолата трябва да се отпечатат всички "щастливи" и различни 4-цифрени числа, разделени с интервал

using System;


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int n1 = 1; n1 <= 9; n1++)
        {
            for (int n2 = 1; n2 <= 9; n2++)
            {
                for (int n3 = 1; n3 <= 9; n3++)
                {
                    for (int n4 = 1; n4 <= 9; n4++)
                    {
                        if (n1 + n2 == n3 + n4 && number % (n1 + n2) == 0)
                            Console.Write($"{n1}{n2}{n3}{n4} ");
                    }
                }
            }
        }
    }
}