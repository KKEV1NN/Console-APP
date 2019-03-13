using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenENUMSwitch
{
	class Program
	{
		

		public enum Day
		{

			maandag,
			dinsdag,
			woensdag,
			donderdag,
			vrijdag,
			zaterdag,
			zondag,

		}

		static void Main(string[] args)
		{
			
			Day vandaag;
			vandaag = Day.woensdag;
			
			Console.WriteLine();

			//Opdracht 1,2,3
			switch (vandaag)
			{
				case Day.maandag:
					Console.WriteLine("ik haat maandage.");
					break;
				case Day.dinsdag:
					Console.WriteLine("alweer de laatste dinsdag van de week.");
					break;
				case Day.woensdag:
					Console.WriteLine("Was het maar donderdag.");
					break;
				case Day.donderdag:
					Console.WriteLine("Was het maar donderdag.");
					break;
				case Day.vrijdag:
					Console.WriteLine("Bijna weekend!");
					break;
				case Day.zaterdag:
					Console.WriteLine("BIEM!");
					break;
				case Day.zondag:
					Console.WriteLine("zachtjes praten asjeblieft.");
					break;
				default:
					break;
			}




		}

	}
}

