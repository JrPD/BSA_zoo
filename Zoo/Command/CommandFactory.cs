using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Command
{
	class CommandFactory
	{
		internal static ICommand GetCommand(Commands cmdName, Animals.AnimalType aType, string aAlias, List<Animals.Animal> zooAnimals)
		{
			if (aType!=null)
			{
				return new AddCmd(aType, aAlias, zooAnimals);
			}
			switch (cmdName)
			{
				case Commands.Remove:
					return new RemoveCmd(aAlias, zooAnimals);
				case Commands.Feed:
					return new FeedCmd(aAlias, zooAnimals);
				case Commands.Treat:
					return new TreatCmd(aAlias, zooAnimals);
				default:
					return null;
			}
		}
	}
	enum Commands
	{
		Add,
		Treat,
		Feed,
		Remove
	}
}
