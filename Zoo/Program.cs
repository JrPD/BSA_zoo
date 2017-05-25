﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Command;

namespace Zoo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Animal> zooAnimals = new List<Animal>();
			zooAnimals.Add(new Lion("leo") { Health=1});
			zooAnimals.Add(new Tiger("timur"));
			zooAnimals.Add(new Elephant("slo"));
			zooAnimals.Add(new Bear("white"));
			zooAnimals.Add(new Wolf("seryj"));
			zooAnimals.Add(new Fox("red"));

			bool allDead = false;
			new Timer((Object stateInfo) => { ChangeState(zooAnimals, ref allDead); }, new AutoResetEvent(false), 0, 5000);

			Console.WriteLine("Commands:");
			Console.WriteLine("Create(animal Type, animalAlias)");
			Console.WriteLine("Feed(animalAlias)");
			Console.WriteLine("Treat(animalAlias)");
			Console.WriteLine("Remove(animalAlias)");
			Console.WriteLine();
			while (zooAnimals.Count > 0 && allDead == false)
			{

				Console.Write("Enter a command: ");

				string cName = string.Empty;
				string aType = string.Empty;
				string aAlias = string.Empty;


				string command = Console.ReadLine();

				var parts = command.Split(new char[] { '(', ')', ',' }).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
				
				if (parts.Count<2 || parts.Count>3)
				{
					Console.WriteLine("Incorrect input");
					continue;
				}
				else
				{
					cName = parts[0];
					if (parts.Count==3)
					{
						aType = parts[1];
						aAlias = parts[2];
					}
					else
					{
						aAlias = parts[1];
					}
				}
				Commands cmdName;
				Enum.TryParse(cName, true, out cmdName);
				AnimalType type;
				Enum.TryParse(aType, true, out type);
				ICommand cmd = CommandFactory.GetCommand(cmdName, type, aAlias, zooAnimals);
				Console.WriteLine(cmd.Execute()); 

			 }
			Console.WriteLine("All animals dead!");

		}

		private static void ChangeState(List<Animal> zooAnimals, ref bool dead)
		{
			foreach (var item in zooAnimals)
			{
				if (item.State!=AnimalState.Dead)
				{
					break;
				}
				dead = true;
				return;
			}

			
			int n = new Random().Next(0, zooAnimals.Count);
			var animal = zooAnimals[n];

			switch (animal.State)
			{
				case AnimalState.Satisfied:
					{
						animal.State = AnimalState.Hungry;
						break;
					}
				case AnimalState.Hungry:
					{
						animal.State = AnimalState.Patient;
						break;
					}
				case AnimalState.Patient:
					{
						if (animal.Health > 0)
						{
							animal.Health--;
							if (animal.Health == 0)
							{
								animal.State = AnimalState.Dead;
							}
							break;

						}else
						{
							animal.State = AnimalState.Dead;
						}
						break;
					}
				default:
					break;
			}
		}

	}
}
