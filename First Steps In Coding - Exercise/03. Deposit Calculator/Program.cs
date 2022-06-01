//Напишете програма, която изчислява каква сума ще получите в края на депозитния период при определен лихвен процент.
//Използвайте следната формула: 
//сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)


using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            decimal deposit = decimal.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            decimal annualInterestPercentage = decimal.Parse(Console.ReadLine());

            decimal annualInterestRate = annualInterestPercentage / 100.00m;
            decimal interest = deposit * annualInterestRate * months / 12.00m;
            decimal totalSum = deposit + interest;

            Console.WriteLine(totalSum);
        }
    }
}


