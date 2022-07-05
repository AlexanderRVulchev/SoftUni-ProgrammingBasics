//На Великден семейството на Деси се събира и тя решава да организира "битка" между великденски яйца. 
//Правилата на "битката" са следните:
//•	Участват двама играчи
//•	Всеки от тях започва с определен брой яйца
//•	При получаване на команда "one" -> първият играч печели => яйцата на втория намаляват с едно 
//•	При получаване на команда "two" -> вторият играч печели => яйцата на първия намаляват с едно
//•	Играта приключва, ако някой от играчите остане без яйца или до получаване на команда "End"
//Вход
//Първоначално се четат два реда:
//1.Брой яйца, които има първият играч - цяло число в интервала [1 … 99]
//2.Брой яйца, които има вторият играч - цяло число в интервала [1 … 99]
//След това до получаване на команда "End" се четe многократно един ред:
//3.Победител - текст - "one" или "two"
//Изход
//Ако първият играч остане без яйца:
//•	"Player one is out of eggs. Player two has {брой останали яйца на втория играч} eggs left."
//Ако вторият играч остане без яйца:
//•	"Player two is out of eggs. Player one has {брой останали яйца на първия играч} eggs left."
//При команда "End" да се отпечатат два реда:
//•	"Player one has {брой останали яйца на първия играч} eggs left."
//•	"Player two has {брой останали яйца на втория играч} eggs left."

using System;

public class Program
{
	public static void Main()
	{
		int player1 = int.Parse(Console.ReadLine());
		int player2 = int.Parse(Console.ReadLine());

		bool endBattle = true;

		string input = Console.ReadLine();
		while (input != "End of battle")
		{
			if (input == "one")
			{
				player2--;
			}
			else if (input == "two")
			{
				player1--;
			}
			if (player1 == 0)
			{
				Console.WriteLine("Player one is out of eggs. Player two has {0} eggs left.", player2);
				endBattle = false;
				break;
			}
			if (player2 == 0)
			{
				Console.WriteLine("Player two is out of eggs. Player one has {0} eggs left.", player1);
				endBattle = false;
				break;
			}
			input = Console.ReadLine();
		}

		if (endBattle)
		{
			Console.WriteLine("Player one has {0} eggs left.", player1);
			Console.WriteLine("Player two has {0} eggs left.", player2);
		}
	}
}