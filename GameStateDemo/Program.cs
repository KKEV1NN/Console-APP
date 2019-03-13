using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStateDemo
{
	class Program
	{
		enum States
		{
			Idle,
			Run,
			Attack,
			Sleep,
		}

		static void Main(string[] args)
		{

			States status;
			status = States.Idle; 
			string stat;
			stat = Console.ReadLine();
			int numStatus; 
			int.TryParse(stat,out numStatus);

			if (numStatus == 1)
				status = States.Idle;
			else if (numStatus == 2)
				status = States.Run;
			else if (numStatus == 2)
				status = States.Attack;
			else if (numStatus == 2)
				status = States.Sleep;

				switch (status)
				{
					case States.Idle:
					Console.WriteLine("You sit around and do nothing.");
					break;
					case States.Run:
					Console.WriteLine("You move around rather quickly");
					break;
					case States.Attack:
					Console.WriteLine("You swing your axe at your enemie");
					break;
					case States.Sleep:
					Console.WriteLine("Real shit.");
					break;
					default:
						break;
				}

		}
	}
}
