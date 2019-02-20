using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{

		static void Main(string[] args)
		{

			double surfaceCircle(double ray)
			{

				return (ray * ray) * Math.PI;
				
			}

			Console.WriteLine(surfaceCircle(5));

			Console.ReadLine();

		}
	}
}
