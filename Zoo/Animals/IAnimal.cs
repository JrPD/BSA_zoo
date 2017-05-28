using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{


	class Animal
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

		public AnimalType AnimalType { get; set; }
	
	}

	enum AnimalState
	{
		Satisfied,
		Hungry,
		Patient,
		Dead
	}
}
