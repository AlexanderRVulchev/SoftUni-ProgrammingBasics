//Румен иска да пребоядиса хола и за целта е наел майстори. Напишете програма, която изчислява разходите за ремонта, предвид следните цени:
//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър
//За всеки случай, към необходимите материали, Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон, разбира се и 0.40 лв. за торбички.
//Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.


using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            double nylon = (double.Parse(Console.ReadLine()) + 2) * 1.50;
            double paint = double.Parse(Console.ReadLine()) * 14.50 * 1.10;
            double diluter = double.Parse(Console.ReadLine()) * 5.00;
            double bags = 0.40;
            double materialsCost = nylon + paint + diluter + bags;

            double workers = double.Parse(Console.ReadLine()) * (materialsCost * 0.30);

            Console.WriteLine(materialsCost + workers);
        }
    }
}


