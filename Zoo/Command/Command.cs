using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.Command
{
	public interface ICommand
	{
		string Execute();
	}
	class IncorrectCmd:ICommand
	{
		#region ICommand Members

		public string Execute()
		{
			return "Incorrect command";
		}

		#endregion
	}
	class AddCmd:ICommand
	{
		private string aAlias;
		private AnimalType aType;
		private List<Animal> zooAnimals;


		public AddCmd(AnimalType aType, string aAlias, List<Animal> zooAnimals)
		{
			// TODO: Complete member initialization
			this.aType = aType;
			this.aAlias = aAlias;
			this.zooAnimals = zooAnimals;
		}

		public string Execute()
		{
			var animal = zooAnimals.Where(a => a.Alias == aAlias).FirstOrDefault();

			if (animal != null)
			{
				return "Animal with this name already exist!";
			}
			else
			{
				if (aType!=AnimalType.Incorrect)
				{
					zooAnimals.Add(AnimalFactory.GetAnimal(aType, aAlias));
					return "Animal added to zoo!";
				}
				return "Incorrect animal type";
			}
		}

	}

	class TreatCmd:ICommand
	{
		private string aAlias;
		private List<Animal> zooAnimals;

		public TreatCmd(string aAlias)
		{
			// TODO: Complete member initialization
			this.aAlias = aAlias;
		}

		public TreatCmd(string aAlias, List<Animal> zooAnimals)
		{
			// TODO: Complete member initialization
			this.aAlias = aAlias;
			this.zooAnimals = zooAnimals;
		}

		public string Execute()
		{
			var animal = zooAnimals.Where(a => a.Alias == aAlias).FirstOrDefault();
			if (animal != null && animal.State != AnimalState.Dead)
			{
				animal.Health = animal.Health < animal.MaxHealth ? ++animal.Health : animal.Health;
				return string.Format("Animal treated! Animal health = {0}", animal.Health);
			}
			return "Animal is dead!";
		}

	}

	class RemoveCmd:ICommand
	{
		private string aAlias;
		private List<Animal> zooAnimals;

		public RemoveCmd(string aAlias, List<Animal> zooAnimals)
		{
			// TODO: Complete member initialization
			this.aAlias = aAlias;
			this.zooAnimals = zooAnimals;
		}

		public string Execute()
		{
			var animal = zooAnimals.Where(a => a.Alias == aAlias).FirstOrDefault();
			if (animal != null && animal.State==AnimalState.Dead)
			{
				zooAnimals.Remove(animal);
				return "Animal removed";
			}
			else
			{
				return "Animal is alive or does not exist!";
			}
		}

	}

	class FeedCmd:ICommand
	{
		private string aAlias;
		private List<Animals.Animal> zooAnimals;

		Animal Animal { get; set; }

		public FeedCmd(string aAlias, List<Animals.Animal> zooAnimals)
		{
			// TODO: Complete member initialization
			this.aAlias = aAlias;
			this.zooAnimals = zooAnimals;
		}

		public string Execute()
		{
			var animal = zooAnimals.Where(a => a.Alias == aAlias).FirstOrDefault();
			if (animal != null && animal.State != AnimalState.Dead)
			{
				animal.State = AnimalState.Satisfied;
				return "Animal is satisfied";
			}
			else
			{
				return "Animal is alive!";
			}
		}

	}
}
