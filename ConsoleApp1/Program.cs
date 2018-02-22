using System;

namespace ZgadulaApp
{
	class Program
	{
		static void Main(string[] args)
		{
			AppInfo();
			GreetUser();
			bool wantPlay = true;
			while (wantPlay)
			{
			Console.WriteLine("Wybierz cyfrę od 1 do 10");
			Random random = new Random();
			int correctNumber = random.Next(1, 10);
			int inputNumber = 0;
				while (inputNumber != correctNumber)
				{
					String inputString = Console.ReadLine();
					if (!int.TryParse(inputString, out inputNumber))
					{
						PrintColorMessage(ConsoleColor.Red, "Nie prawidłowy format danych!");
						continue;
					}
					inputNumber = int.Parse(inputString);
					if (inputNumber != correctNumber)
					{
						PrintColorMessage(ConsoleColor.Red,"Zła odpowiedź, spróbuj inną cyfrę!");
					}
				}
				PrintColorMessage(ConsoleColor.Yellow, "Poprawna odpowiedź!");
				Console.WriteLine("Chcesz zagrać ponownie ? [T czy N]");
				String answer = Console.ReadLine().ToUpper();
				bool fine = false;
				while (!fine)
				{
					answer = Console.ReadLine().ToUpper();
					if (answer == "N")
					{
						Console.WriteLine("Dzięki, że zagrałeś w moją grę! Do zobacznia!");
						wantPlay = false;
						fine = true;
					}
					else if (answer == "T")
					{
						fine = true;
					}
					else
					{
						Console.WriteLine("Musisz wpisać T lub N");
					}
				}
			}
		}
		static void AppInfo()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			String appAuthor = "Marcin";
			String appVersion = "1.0.0";
			Console.WriteLine("ZGADULA: Wersja {0} stworzona przez {1}", appVersion, appAuthor);
			Console.ResetColor();
		}

		static void PrintColorMessage(ConsoleColor color,string m)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(m);
			Console.ResetColor();
		}

		static void GreetUser()
		{
			Console.WriteLine("Jak Ci na imię?");
			String name = Console.ReadLine();
			Console.WriteLine("Witaj {0}! Zagrajmy w grę...", name);
		}
	}
}
