//Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN).
//Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
