//За рождения си ден Любомир получил аквариум с формата на паралелепипед.
//Първоначално прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.
//Трябва да се пресметне колко литра вода ще събира аквариума, ако се знае,
//че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа. 
//Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 
//Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.


using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double stuffPercentage = double.Parse(Console.ReadLine()) / 100.0;

            double volume = lenght * width * height / 1000.0;
            double stuff = volume * stuffPercentage;

            double total = volume - stuff;

            Console.WriteLine(total);

        }
    }
}