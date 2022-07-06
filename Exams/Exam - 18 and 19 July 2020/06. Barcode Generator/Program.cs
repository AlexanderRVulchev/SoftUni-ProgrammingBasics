//Техниката в магазин за коледни украси се разваля.
//Артикулите, които съдържат четни числа в своя баркод не могат да бъдат маркирани от касиерите.
//Вашата задача е, да напишете програма, която генерира всички баркодове, които НЕ съдържат четни цифри в себе си.
//Вход:
//•	Две четирицифрени числа, които показват обхвата на баркодовете, които трябва да промените.
//•	Първи ред – четирицифрено число – началото на обхвата. Цяло число в интервала [1000…9999]
//•	Втори ред – четирицифрено число – края на обхвата. Цяло число в интервала [1000…9999]
//Изход:
//На конзолата трябва да се отпечатат всички "баркодове", които НЕ съдържат четна цифра в себе си, разделени с интервал.

using System;


class Program
{
    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        int x1 = int.Parse(first[0].ToString());
        int x2 = int.Parse(first[1].ToString());
        int x3 = int.Parse(first[2].ToString());
        int x4 = int.Parse(first[3].ToString());
        int y1 = int.Parse(second[0].ToString());
        int y2 = int.Parse(second[1].ToString());
        int y3 = int.Parse(second[2].ToString());
        int y4 = int.Parse(second[3].ToString());

        for (int i1 = x1; i1 <= y1; i1++)
        {
            for (int i2 = x2; i2 <= y2; i2++)
            {
                for (int i3 = x3; i3 <= y3; i3++)
                {
                    for (int i4 = x4; i4 <= y4; i4++)
                    {
                        if (i1 % 2 != 0 && i2 % 2 != 0 && i3 % 2 != 0 && i4 % 2 != 0)
                        {
                            Console.Write($"{i1}{i2}{i3}{i4} ");
                        }
                    }
                }
            }
        }
    }
}