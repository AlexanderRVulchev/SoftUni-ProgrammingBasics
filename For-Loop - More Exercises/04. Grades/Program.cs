//Напишете програма, която да пресмята статистика на оценки от изпит.
//В началото програмата получава броят на студентите явили се на изпита и за всеки студент неговата оценка.
//На края програмата трябва да изпечата процента на студенти с оценка между 2.00 и 2.99, между 3.00 и 3.99, между 4.00 и 4.99, 5.00 или повече.
//Също така и средният успех на изпита.
//Вход
//От конзолата се четат поредица от числа, всяко на отделен ред:
//•	На първия ред – броя на студентите явили се на изпит – цяло число в интервала [1...1000]
//•	За всеки един студент на отделен ред – оценката от изпита – реално число в интервала [2.00...6.00]
//Изход
//Да се отпечатат на конзолата 5 реда, които съдържат следната информация:
//Ред 1 - "Top students: {процент студенти с успех 5.00 или повече}%"
//Ред 2 - "Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
//Ред 3 - "Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
//Ред 4 - "Fail: {по-малко от 3.00}%"
//Ред 5 - "Average: {среден успех}"
//Всички числа трябва да са форматирани до вторият знак след десетичната запетая.

using System;

class Program
{
    static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        double allGrades = 0;

        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 3) two++;
            else if (grade < 4) three++;
            else if (grade < 5) four++;
            else five++;
            allGrades += grade;
        }
        Console.WriteLine($"Top students: {five * 100.0 / students:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {four * 100.0 / students:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {three * 100.0 / students:f2}%");
        Console.WriteLine($"Fail: {two * 100.0 / students:f2}%");
        Console.WriteLine($"Average: {allGrades / students:f2}");
    }
}