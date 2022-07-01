//Футболен отбор участва в благотворителен турнир. На този турнир отборът играе три мача като домакин.
//Да се напише програма, която изчислява колко победи, равенства и загуби има отборът по време на турнира, спрямо резултатите от мачовете.
//*Забележка: Отборът винаги е домакин, следователно първата цифра от резултата съответства на головете вкарани от него.
//Вход
//От конзолата се четат 3 реда:
//1.Резултат от първия мач – текст 
//2.	Резултат от втория мач – текст 
//3.	Резултат от третия мач – текст 
//Резултатите ще са в следния формат: "2:0", "0:1", "1:1" и т.н.
///броят голове винаги ще бъде едноцифрено число/
//Изход
//На конзолата да се отпечатат три реда:
//•	"Team won {брой спечелени мачове} games."
//•	"Team lost {брой загубени мачове} games."
//•	" Drawn games: {брой равни мачове}"

using System;

public class Program
{
	public static void Main()
	{
		int wins = 0;
		int losses = 0;
		int draws = 0;

		for (int i = 1; i <= 3; i++)
		{
			string input = Console.ReadLine();
			int we = int.Parse(input[0].ToString());
			int they = int.Parse(input[2].ToString());
			if (we > they) wins++;
			else if (we == they) draws++;
			else if (we < they) losses++;
		}
		Console.WriteLine("Team won {0} games.", wins);
		Console.WriteLine("Team lost {0} games.", losses);
		Console.WriteLine("Drawn games: {0}", draws);
	}
}