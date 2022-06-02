//Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.
//Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).
//На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle). 
//•	Ако фигурата е квадрат (square): на следващия ред се чете едно дробно число - дължина на страната му
//•	Ако фигурата е правоъгълник (rectangle): на следващите два реда четат две дробни числа - дължините на страните му
//•	Ако фигурата е кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
//•	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея
//Резултатът да се закръгли до 3 цифри след десетичната запетая. 

using System;

internal class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        double area = double.MinValue;
        double x = double.Parse(Console.ReadLine());

        if (type == "square")
        {
            area = x * x;
        }
        else if (type == "rectangle")
        {
            double y = double.Parse(Console.ReadLine());
            area = x * y;
        }
        else if (type == "circle")
        {
            area = Math.PI * x * x;
        }
        else if (type == "triangle")
        {
            double h = double.Parse(Console.ReadLine());
            area = x * h / 2;
        }

        Console.WriteLine($"{area:f3}");
    }
}
