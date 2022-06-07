//В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
//•	Premiere – премиерна прожекция, на цена 12.00 лева.
//•	Normal – стандартна прожекция, на цена 7.50 лева.
//•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
//Напишете програма, която чете тип прожекция (стринг), брой редове и брой колони в залата (цели числа),
//въведени от потребителя, и изчислява общите приходи от билети при пълна зала.
//Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  

using System;

public class Program
{
	public static void Main()
	{
		string type = Console.ReadLine();
		int c = int.Parse(Console.ReadLine());
		int r = int.Parse(Console.ReadLine());

		double sales = r * c;
		if (type == "Premiere") sales *= 12.00;
		else if (type == "Normal") sales *= 7.50;
		else if (type == "Discount") sales *= 5.00;

		Console.WriteLine("{0:f2} leva", sales);
	}
}