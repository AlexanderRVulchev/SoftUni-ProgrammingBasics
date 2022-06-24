//Напишете програма, която прочита скрито съобщение в поредица от символи.
//Те се получават по един на ред до получаване на командата "End".
//Думите се образуват от буквите в реда на четенето им. Символите, които не са латински букви трябва да бъдат игнорирани.
//Думите скрити в потока са разделени от тайна команда от три букви – "c", "o" и "n".
//При първото получаване на една от тези букви, тя се маркира като срещната, но не се запазва в думата.
//При всяко следващо нейно срещане се записва нормално в думата.
//След като са налични и трите символа от командата, се печата думата и интервал " ".
//Започва се нова дума, която по същия начин чака тайната команда, за да бъде отпечатана.
//Вход
//От конзолата се чете поредица от редове с един символ на всеки до получаване на командата "End".
//Изход
//На конзолата се печата на един ред всяка дума след тайната команда, следвана от интервал.

using System;


class Program
{
    static void Main(string[] args)
    {
        string word = string.Empty;
        string input = Console.ReadLine();
        bool gotC = false;
        bool gotO = false;
        bool gotN = false;

        while (input != "End")
        {
            char symbol = input[0];
            bool isValid = (symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z');
            if (!isValid) { input = Console.ReadLine(); continue; }
            else if (symbol == 'c' && !gotC) gotC = true;
            else if (symbol == 'o' && !gotO) gotO = true;
            else if (symbol == 'n' && !gotN) gotN = true;
            else word += symbol;

            if (gotC && gotO && gotN)
            {
                gotO = false; gotN = false; gotC = false;
                Console.Write(word + " ");
                word = String.Empty;
            }
            input = Console.ReadLine();
        }
    }
}