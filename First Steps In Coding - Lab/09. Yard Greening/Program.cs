/*Божидара разполага с няколко къщи на Черноморието и желае да озелени дворовете на някои от тях, като по този начин създаде уютна обстановка и комфорт на гостите си. 
 * За целта е наела фирма.
Напишете програма, която изчислява необходимате сума, които Божидара ще трябва да заплати на фирмата изпълнител на проекта. 
Цената на един кв. м. е 7.61 лв със ДДС. Понеже нейният двор е доста голям, фирмата изпълнител предлага 18% отстъпка от крайната цена.*/

using System;

namespace Presentation
{
    internal class Program
    {
        static void Main()
        {
            double area = double.Parse(Console.ReadLine());
            double totalCost = area * 7.61;
            double discount = totalCost * 0.18;
            double endPrice = totalCost - discount;

            Console.WriteLine($"The final price is: {endPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
