//Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r,
//като форматирате изхода в следния вид: "<calculated area>"
//"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.

using System;

public class Program
{
	public static void Main()
	{
		double r = double.Parse(Console.ReadLine());
		Console.WriteLine("{0:f2}", r * r * Math.PI);
		Console.WriteLine("{0:f2}", 2 * r * Math.PI);
	}
}