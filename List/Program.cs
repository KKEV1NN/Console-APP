using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
	class Program
	{
		#region CustomClass
		public class Cube
		{
			
			public string NameOfCube;
			public string ColourOfCube;
			public int IDOfCube;

			public override string ToString()
			{
				return "ID: " + IDOfCube + "  Name: " + NameOfCube + "  Colour" + ColourOfCube; 
			}

			public override bool Equals(object obj)
			{
				if (obj == null) return false;
				Cube objAsPart = obj as Cube;
				if (objAsPart == null) return false;
				else return Equals(objAsPart);
			}
			public override int GetHashCode()
			{
				return IDOfCube;
			}
			#endregion

		}

		static void Main(string[] args)
		{
			#region Opdracht 1&2
			List<int> primeNum = new List<int>();

			primeNum.Add(2);
			primeNum.Add(3);
			primeNum.Add(5);
			primeNum.Add(7);
			primeNum.Add(11);

			Console.WriteLine("Maak een lijst aan met daarin 5 priemgetallen.");

			foreach (var item in primeNum)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("\nIn de Unity of Windows console, schrijf ‘true’ als het getal 3 voorkomt in de lijst.");

			if (primeNum.Contains(3))
			{
				Console.Write("\nTrue");

			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 3
			Console.WriteLine("Sorteer de lijst met priemgetallen in oplopende volgorde.");

			primeNum.Sort();

			foreach (var item in primeNum)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 4
			Console.WriteLine("Sorteer de lijst met priemgetallen in aflopende volgorde.");

			primeNum.Reverse();

			foreach (var item in primeNum)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 5
			List<string> nameList = new List<string>();
			string playerInput;

			Console.WriteLine("Maak een lijst aan met 6 namen. Vraag voor elke naam input aan de gebruike.");
			Console.WriteLine("Type nu 6 namen ... of laat ze leeg?");

			for (int i = 0; i < 6; i++)
			{
				do
				{
					playerInput = Console.ReadLine();
					nameList.Add(playerInput);
					Console.Clear();

				} while (playerInput == null);

			}

			foreach (var item in nameList)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 6
			Console.WriteLine("Maak nog een lijst met 3 namen, die mag je zelf invullen");

			List<string> nameList2 = new List<string>();

			nameList2.Add("Itadaki Seiki");
			nameList2.Add("Mankitsu Happening");
			nameList2.Add("Amakano");

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 7
			Console.WriteLine("Voeg de 2 lijsten samen en schrijf ze in de console.");

			nameList.AddRange(nameList2);

			foreach (var item in nameList)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdracht 8&9

			Console.WriteLine("Verwijder nu random twee namen uit de lijst, gebruik hiervoor de correcte code & Schrijf in de console hoeveel namen er nu in de lijst staan.");

			Random randomNum = new Random();
			int randomNum1 = randomNum.Next(0, 9);
			int randomNum2 = randomNum.Next(0, 8);

			nameList.RemoveAt(randomNum1);
			nameList.RemoveAt(randomNum2);

			foreach (var item in nameList)
			{

				Console.WriteLine(item);

			}

			Console.WriteLine("Er zijn maar {0} namen over", nameList.Count);

			Console.ReadKey();
			#endregion

			#region Opdracht 10 
			Console.Clear();

			nameList.RemoveRange(3, 4);

			foreach (var item in nameList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("Verwijder nu elke naam vanaf (en inclusief) index 3. ");

			Console.ReadKey();

			Console.Clear();
			#endregion

			#region Opdacht 11
			nameList.Clear();

			Console.WriteLine("You emptied the list");

			Console.ReadKey();
			
			Console.Clear();
			#endregion

			#region Opdracht 12 TRIPLEACTIONSUPERBONUS

			Console.WriteLine("TRIPLEACTIONSUPERBONUS");

			List<Cube> cubes = new List<Cube>();

			cubes.Add(new Cube() { NameOfCube = "Luke", IDOfCube = 1234, ColourOfCube = " blue" });
			cubes.Add(new Cube() { NameOfCube = "Peter", IDOfCube = 3232, ColourOfCube = " blue" });
			cubes.Add(new Cube() { NameOfCube = "David", IDOfCube = 4245, ColourOfCube = " red" });
			cubes.Add(new Cube() { NameOfCube = "Drake", IDOfCube = 3525, ColourOfCube = " green" });
			cubes.Add(new Cube() { NameOfCube = "Josh", IDOfCube = 4325, ColourOfCube = " red" });
			cubes.Add(new Cube() { NameOfCube = "Kevin", IDOfCube = 6453, ColourOfCube = " blue" });
			cubes.Add(new Cube() { NameOfCube = "Frank", IDOfCube = 1123, ColourOfCube = " green" });
			cubes.Add(new Cube() { NameOfCube = "Helen from accounting", IDOfCube = 3242, ColourOfCube = " red" });
			cubes.Add(new Cube() { NameOfCube = "Edgar", IDOfCube = 3432, ColourOfCube = " red" });
			cubes.Add(new Cube() { NameOfCube = "Anton", IDOfCube = 6435, ColourOfCube = " green" });

			foreach (var item in cubes)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();


			var resID = cubes.OrderBy(a => a.IDOfCube);

			Console.WriteLine("TRIPLEACTIONSUPERBONUS(sorted)");

			foreach (var item in resID)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();

			Console.Clear();
			#endregion

			/* Logica
			 * 
			 *	Opdracht 1 
			 * 
			 *		&&
			 *	
			 * 
			 *	Opdracht 2 
			 * 
			 *		Als bijde variabelen in de operator waarzijn dan is wat er onder zit ook waar.
			 *		
			 *	Opdracht 3 
			 *	
			 *		0
			 *		0
			 *		0
			 *		1
			 *	
			 *	Opdracht 4
			 *	
			 *		||
			 *	
			 *	Opdracht 5
			 *		
			 *		Het is een of het ander dat waar moet zijn
			 * 
			 *	Opdracht 6
			 *	
			 *		0
			 *		1
			 *		1
			 *		1
			 *	
			 *	Opdracht 7
			 *	
			 *		!
			 *	
			 *	Opdracht 8
			 *	
			 *		Waneer je het voor een var zet dan word een var niet true. 
			 *	
			 *	Opdracht 9
			 *		
			 *		if(a || !a && b == false)
			 *		
			 *		if(a && !b)
			 *		
			 *		if(!a && a || !b && b) 
			 *	
			 *	Opdracht 10
			 *	
			 *		if(carhasFuel || carhasPower )
			 *		{
			 *		
			 *			canDrive();
			 *		
			 *		}
			 *		
			*/

		}
	}
}
