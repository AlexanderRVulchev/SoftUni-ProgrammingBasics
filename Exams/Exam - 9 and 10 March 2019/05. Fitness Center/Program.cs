//Напишете програма, която да изчислява броя на посетителите в един фитнес център.
//В началото програмата получава броя на посетителите на фитнеса и за всеки човек - дейността, която извършва във фитнеса.
//На края програмата трябва да отпечата броят трениращи за всяка една дейност ("Back", "Chest", 'Legs", "Abs")
//и броят клиенти, закупили продукт ("Protein shake", "Protein bar").
//Също така - процентът трениращи (спрямо общия брой посетители) и процентът на клиентите, закупили продукт от фитнеса.
//Вход
//От конзолата се чете число, след това поредица от низове, всяко на отделен ред:
//•	На първия ред – броят на посетителите във фитнеса – цяло число в интервала [1...1000]
//•	За всеки един посетител на отделен ред – дейността във фитнеса – текст ("Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar")
//Изход
//Да се отпечатат на конзолата 8 реда, които съдържат следната информация:
//Ред 1 - "{брой хора трениращи гръб} - back"
//Ред 2 - "{брой хора трениращи гърди} - chest"
//Ред 3 - "{брой хора трениращи крака} - legs"
//Ред 4 - "{брой хора трениращи коремни мускули} - abs"
//Ред 5 - "{брой хора закупили протеинов шейк} - protein shake"
//Ред 6 - "{брой хора закупили протеинов блок} - protein bar"
//Ред 7 - "{процент на хората дошли да тренират}% - work out"
//Ред 8 - "{процент на хората дошли да купят протеин}% - protein"
//Всички проценти трябва да са форматирани до втората цифра след десетичния знак.

using System;


public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int back = 0;
        int chest = 0;
        int legs = 0;
        int abs = 0;
        int shake = 0;
        int bar = 0;

        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Back": back++; break;
                case "Chest": chest++; break;
                case "Legs": legs++; break;
                case "Abs": abs++; break;
                case "Protein shake": shake++; break;
                case "Protein bar": bar++; break;
            }
        }
        Console.WriteLine($"{back} - back");
        Console.WriteLine($"{chest} - chest");
        Console.WriteLine($"{legs} - legs");
        Console.WriteLine($"{abs} - abs");
        Console.WriteLine($"{shake} - protein shake");
        Console.WriteLine($"{bar} - protein bar");
        Console.WriteLine($"{(back + chest + legs + abs) * 100.0 / n:f2}% - work out");
        Console.WriteLine($"{(shake + bar) * 100.0 / n:f2}% - protein");
    }
}