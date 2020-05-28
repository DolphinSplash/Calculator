using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			string Truth = "yes";
			Console.WriteLine("Press any key to start");
			Console.ReadLine();
			while (Truth != "no")
			{
				Constantin();
				Console.WriteLine("Do you want to continue?");
				Truth = Console.ReadLine();
			}


			Console.WriteLine("Press any key to end");
			Console.ReadLine();
		}


		public static int olivia(int i, int g)
		{
			return i + g;
		}

		public static int carl(int i, int g)
		{
			return i - g;
		}

		public static int kirill(int i, int g)
		{
			return i * g;
		}

		public static int kaleb(int i, int g)
		{
			return i / g;
		}

		public static int terra(int i)
		{
			return i * i;
		}

		public static double monya(int i)
		{
			return Math.Sqrt(i);
		}

		public static double nana(int i, int g)
		{
			return Math.Pow(i, g);
		}
		public static int Alferd()
		{
			Console.WriteLine("Write a number");
			int Claus = Convert.ToInt32(Console.ReadLine());
			return Claus;
		}

		public static void Constantin()
		{
			Console.WriteLine("Choose your option");
			string OPTION = Console.ReadLine();

			switch (OPTION)
			{
				case "+":
					Console.WriteLine(olivia(Alferd(), Alferd()));
					break;
				case "-":
					Console.WriteLine(carl(Alferd(), Alferd()));
					break;
				case "*":
					Console.WriteLine(kirill(Alferd(), Alferd()));
					break;
				case "/":
					Console.WriteLine(kaleb(Alferd(), Alferd()));
					break;
				case "^2":
					Console.WriteLine(terra(Alferd()));
					break;
				case "/^2":
					Console.WriteLine(monya(Alferd()));
					break;
				case "^":
					Console.WriteLine(nana(Alferd(), Alferd()));
					break;
			}


		}
	}
}
