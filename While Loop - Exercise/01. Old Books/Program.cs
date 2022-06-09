//Ани отива до родния си град след много дълъг период извън страната.
//Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга.
//Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея книга(текст).
//Докато Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст).
//Книгите в библиотеката са свършили щом получите текст "No More Books".
//•	Ако не открие търсената книгата да се отпечата на два реда: 
//o "The book you search is not here!"
//o "You checked {брой} books."
//•	Ако открие книгата си се отпечатва един ред:
//o "You checked {брой} books and found it."

using System;

internal class Program
{
    static void Main()
    {
        string anisBook = Console.ReadLine();
        bool isFound = false;
        int bookcount = 0;

        while (true)
        {
            string bookName = Console.ReadLine();
            if (bookName == "No More Books") break;
            if (bookName == anisBook)
            {
                isFound = true;
                break;
            }
            else bookcount++;
        }
        if (isFound) Console.WriteLine($"You checked {bookcount} books and found it.");
        else Console.WriteLine($"The book you search is not here!\nYou checked {bookcount} books.");
    }
}
