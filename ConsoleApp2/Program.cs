using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		

		//opdracht 1
		static void Main(string[] args)
		{

			double surfaceCircle(double ray)
			{

				return (ray * ray) * Math.PI;
				
			}

			Console.WriteLine(surfaceCircle(5));

			Console.ReadLine();

		}

		//opdracht 2
		int ArrowDamageCalculator(int distance, int dmg)
		{
			if (distance > 50 && distance < 100)
			{

			}

			if (distance < 50)
			{
				dmg = dmg / 2;
			}

			if(distance > 100)
			{
				dmg = dmg * 2;
			}

			return dmg; 
		}

		//opdracht 3
		int ArrowDamageCalculator(int distance, int pull, int dmg)
		{

			dmg = (distance / 2) * pull; 

			return dmg;
		}

		//opdracht 4
		bool HitOrMiss(int distance, int dmg)
		{

			if(dmg > distance)
			{
				return true;
			} else
			{
				return false;
			}

			
		}

	}
}
