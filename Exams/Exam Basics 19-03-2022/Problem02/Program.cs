using System;


namespace Problem02
{
    internal class Program
    {
        static void Main()
        {
            double party = double.Parse(Console.ReadLine());            

            int loveLettersNum = int.Parse(Console.ReadLine());
            double loveLetters = loveLettersNum * 0.60;
            int rosesNum = int.Parse(Console.ReadLine());
            double roses = rosesNum * 7.20;
            int keychainNum = int.Parse(Console.ReadLine());
            double keychain = keychainNum * 3.60;
            int caricatureNum = int.Parse(Console.ReadLine());
            double caricature = caricatureNum * 18.20;
            int surpriseNum = int.Parse(Console.ReadLine());
            double surprise = surpriseNum * 22.00;

            int items = loveLettersNum + rosesNum + keychainNum + caricatureNum + surpriseNum;
            double total = loveLetters + roses + keychain + caricature + surprise;
            if (items >= 25) total *= 0.65;
            total *= 0.9;

            if (total >= party) Console.WriteLine($"Yes! {total - party:f2} lv left.");
            else Console.WriteLine($"Not enough money! {party - total:f2} lv needed.");
        }
    }
}
