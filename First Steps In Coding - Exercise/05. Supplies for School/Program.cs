//Учебната година вече е започнала и отговорничката на 10Б клас - Ани трябва да купи определен брой пакетчета с химикали, пакетчета с маркери, както и препарат за почистване на дъска.
//Тя е редовна клиентка на една книжарница, затова има намаление за нея, което представлява някакъв процент от общата сума.
//Напишете програма, която изчислява колко пари ще трябва да събере Ани, за да плати сметката, като имате предвид следния ценоразпис: 
//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//•	Препарат - 1.20 лв (за литър)

using System;

namespace SU_Resource
{
    internal class Program
    {
        static void Main()
        {
            int pensAmount = int.Parse(Console.ReadLine());
            int markersAmount = int.Parse(Console.ReadLine());
            int cleanerAmount = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine()) / 100.00;

            double penPrice = 5.80;
            double markerPrice = 7.20;
            double cleanerPrice = 1.20;

            double pensCost = pensAmount * penPrice;
            double markersCost = markersAmount * markerPrice;
            double cleanerCost = cleanerAmount * cleanerPrice;

            double allCost = pensCost + markersCost + cleanerCost;
            double discount = allCost * discountPercentage;

            Console.WriteLine(allCost - discount);

        }
    }
}