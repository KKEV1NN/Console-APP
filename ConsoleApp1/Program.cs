using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
	class Program { 

		static void Main(string[] args)
		{
			ConsoleSpinner spin = new ConsoleSpinner();
			Console.Write("spin");
			while (true)
			{
				spin.Turn();
			}

			//int m_A = 1;
			//int m_B = 2;

			//Console.WriteLine("hello world!");
			//Console.WriteLine("Press enter to stop the suffering!");
			//Console.WriteLine("A is {0}, B is {1}", m_A, m_B);
			//Console.Beep(307,1);


			//do
			//{
			//	Console.WriteLine("Choose 1 || 2 || 3");
			//	m_UserInput = Console.ReadLine();
			//} while (!int.TryParse(m_UserInput, out choice) || choice < 1 || choice > 3 || choice != 648513);

			//Console.WriteLine("Choose a number between one and ten");
			//m_UserInput = Console.ReadLine();

			//while (!int.TryParse(m_UserInput, out choice) || choice < 1 || choice > 10)
			//{
			//	Console.WriteLine("You entered {0}. You did not. Please again", m_UserInput);
			//	Console.WriteLine("Please enter a number between one and ten");
			//	m_UserInput = Console.ReadLine();
			//}

			//for (int i = 0; i < 99999; i++)
			//{
			//	Console.Beep(1000, 400);
			//	Console.Beep(1200, 100);
			//	Console.Beep(1300, 100);
			//	Console.Beep(1400, 100);
			//	Console.Beep(1000, 400);
			//	Console.Beep(1200, 100);
			//	Console.Beep(1300, 100);
			//	Console.Beep(1400, 100);
			//	Console.Beep(1000, 400);
			//	Console.Beep(1200, 100);
			//	Console.Beep(1300, 100);
			//	Console.Beep(1400, 100);
			//	Console.Beep(1600, 100);
			//	Console.Beep(1800, 100);
			//	Console.Beep(900, 100);
			//	Console.Beep(1000, 100);
			//	Console.Beep(2000, 100);
			//	Console.Beep(500, 100);

		}


	}

	public class ConsoleSpinner
	{
		int counter;
		public
			 ConsoleSpinner()
		{
			counter = 0;
		}
		public void Turn()
		{
			counter++;
			switch (counter % 6)
			{
				case 0:
					Console.Write("/"); Console.Beep(1000, 100); System.Diagnostics.Process.Start("https://bit.ly/1cm8Sqi");
				break;
				case 1:
					Console.Write("-"); Console.Beep(700, 100); System.Diagnostics.Process.Start("https://bit.ly/IqT6zt");
				break;
				case 2:
					Console.Write("\\"); Console.Beep(800, 100); System.Diagnostics.Process.Start("https://bit.ly/1cm8Sqi");
				break;
				case 3:
					Console.Write("|"); Console.Beep(1400, 100); System.Diagnostics.Process.Start("https://bit.ly/IqT6zt");
				break;
				case 4:
					Console.Write("/"); Console.Beep(2000, 100); System.Diagnostics.Process.Start("https://bit.ly/1cm8Sqi");
				break;
				case 5:
					Console.Write("--"); Console.Beep(1000, 100); System.Diagnostics.Process.Start("https://bit.ly/IqT6zt");
				break;
			}
			Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
		}
	}
}

