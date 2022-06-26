//Имаме банкноти и монети по 1лв., по 2лв. и по 5лв.
//Да се напише програма, която прочита въведените от потребителя брой банкноти и монети и сума,
//и извежда на екран всички възможни начини по които сумата може да се изплати с наличните банкноти. 
//Вход
//Входът се чете от конзолата и съдържа точно 4 реда:
//1.Брой монети по 1лв. - цяло положително число;
//2.Брой монети по 2лв. - цяло положително число;
//3.Брой банкноти по 5лв. - цяло положително число;
//4.Сума - цяло положително число в интервала [1…1000];
//Изход
//Да се отпечатат на конзолата всички комбинации от дадените номинали, образуващи сумата, форматирани по следния начин:
//o "{бр. 1лв.} * 1 lv. + {бр. 2лв.} * 2 lv. + {бр. 5лв.} * 5 lv. = {сума} lv."

using System;

public class Program
{
	public static void Main()
	{
		int amount1 = int.Parse(Console.ReadLine());
		int amount2 = int.Parse(Console.ReadLine());
		int amount5 = int.Parse(Console.ReadLine());
		int sum = int.Parse(Console.ReadLine());

		for (int count1 = 0; count1 <= amount1; count1++)
		{
			for (int count2 = 0; count2 <= amount2; count2++)
			{
				for (int count5 = 0; count5 <= amount5; count5++)
				{
					if (count1 * 1 + count2 * 2 + count5 * 5 == sum)
					{
						Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", count1, count2, count5, sum);
					}
				}
			}
		}
	}
}