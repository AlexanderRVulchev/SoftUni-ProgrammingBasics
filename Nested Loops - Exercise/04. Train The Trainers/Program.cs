//Курсът "Train the trainers" е към края си и финалното оценяване наближава.
//Вашата задача е да помогнете на журито което ще оценява презентациите,
//като напишете програма в която да изчислява средната оценка от представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
//От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
//След това на отделен ред се прочита името на презентацията - текст
//За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
//След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
// "{името на презентацията} - {средна оценка}."
//След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
//Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.

using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string theme = string.Empty;
        double grade = 0;
        double totalGrade = 0;
        int numberThemes = 0;

        while (input != "Finish")
        {
            theme = input;
            for (int i = 1; i <= n; i++)
            {
                grade += double.Parse(Console.ReadLine());
            }
            grade = grade / n;
            Console.WriteLine($"{theme} - {grade:f2}.");
            totalGrade += grade;
            numberThemes++;
            grade = 0;
            input = Console.ReadLine();
        }
        Console.WriteLine($"Student's final assessment is {(totalGrade / numberThemes):f2}.");
    }
}