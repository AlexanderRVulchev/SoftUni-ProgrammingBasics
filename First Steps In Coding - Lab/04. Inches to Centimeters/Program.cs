//Да се напише програма, която чете от конзолата реално число и го преобразува от инчове в сантиметри. За целта умножете инчовете по 2.54 (1 инч = 2.54 сантиметра).

using System;


internal class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double centimeters = a * 2.54;
        Console.WriteLine(centimeters);
    }
}
