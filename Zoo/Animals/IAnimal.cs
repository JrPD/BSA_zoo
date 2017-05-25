using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
	interface IAnimal
	{
		void Eat();
	}

	class Animal:IAnimal
	{
		public Animal(string alias)
		{
			Alias = alias;
			State = AnimalState.Satisfied;
		}

		public sbyte Health;
		public sbyte MaxHealth;
		
		public AnimalState State;

		public string Alias { get; set; }
		#region IAnimal Members

		public void Eat()
		{
			Console.WriteLine(Alias+" eaten...");
		}

		#endregion
	}

	enum AnimalState
	{
		Satisfied,
		Hungry,
		Patient,
		Dead
	}
}
