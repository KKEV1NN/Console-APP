using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ListsCMD
{
	public class Game
	{

		//static string characterName = "The Traveler";

		//public static void StartGame()
		//{
		//	Console.WriteLine("Super Awesome Adventure!");
		//	Console.WriteLine("Welcome to ...");
		//	NamedCharacter();

		//}

		//static void NamedCharacter()
		//{
		//	Console.WriteLine("What would you like your character's name to be?");

		//	characterName = Console.ReadLine();

		//	Console.WriteLine("Great! your character is now named " + characterName);
		//	Choice();

		//}

		//static void Choice()
		//{
		//	string input = "";
		//	Console.WriteLine(characterName + "You are presented with two roads... one leads through a forest (A) and the other through a cave(B)...");
		//	input = Console.ReadLine();

		//	if (input.ToLower()== "a")
		//	{
		//		Console.WriteLine("You walk down a overgrown road...");
		//	} else
		//	{
		//		Console.WriteLine("You slipped and fell to your demise...");
		//		endGame();
		//	}
		//}

		//public static void endGame()
		//{
		//	Console.WriteLine(characterName + " story ends here...");

		//	Console.WriteLine("Press enter to exit...");
		//}

	}

	class Item
	{

	}

	class Program
	{
		static void Main(string[] args)
		{
			#region Speech Synth
			//SpeechSynthesizer synth = new SpeechSynthesizer();

			//synth.SetOutputToDefaultAudioDevice();

			//synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

			//synth.Volume = 100;
			//synth.Rate = 0;
			#endregion

			#region Lists w/ loops
			//List<int> consecutiveNumbers = new List<int>();

			//int listItems = 11;

			//for (int i = 0; i < listItems; i++)
			//{
			//	consecutiveNumbers.Add(i);
			//}

			//Console.WriteLine("List with consecutive numbers");
			//foreach  (int n in consecutiveNumbers)
			//{
			//	Console.WriteLine(n);
			//}

			//Console.ReadLine();

			//List<int> randomNumbers = new List<int>();
			//Random rnd = new Random();

			//for (int  i = 0;  i <listItems;  i++)
			//{
			//	randomNumbers.Add(rnd.Next(1,11));
			//}

			//Console.WriteLine("List with random numbers");

			//foreach (var n in randomNumbers)
			//{
			//	Console.WriteLine(n);
			//}

			//Console.ReadLine();
			#endregion

			#region Random number list
			//randomNumbers.Add(50);

			//Console.WriteLine("Numbers added up until 50");

			//foreach (var n in randomNumbers)
			//{
			//	Console.WriteLine(n);
			//}

			//Console.ReadLine();

			//if (randomNumbers.Contains(40))
			//{
			//	Console.Beep();
			//} else
			//{
			//	synth.Speak("You would not believe your eyes If ten million fireflies Lit up the world as I fell asleep");
			//}

			//Console.ReadLine();
			#endregion

			//Game.StartGame();
			//Console.Read();


			

		}
	}
}
