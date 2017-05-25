using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
	class AnimalFactory
	{
		public static Animal GetAnimal(AnimalType type, string alias)
		{
			switch (type)
			{
				case AnimalType.Lion:
					return new Lion(alias);
				case AnimalType.Tiger:
					return new Tiger(alias);
				case AnimalType.Elephant:
					return new Elephant(alias);
				case AnimalType.Bear:
					return new Bear(alias);
				case AnimalType.Wolf:
					return new Wolf(alias);
				case AnimalType.Fox:
					return new Fox(alias);
				default:
					return null;
			}
		}
	}

	enum AnimalType
	{
		Incorrect,
		Lion,
		Tiger,
		Elephant,
		Bear,
		Wolf,
		Fox

	}
}
