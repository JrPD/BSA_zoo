using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo
{
	interface IZooRepo
	{
		IEnumerable<Animal> GetAnimals();
	}
	interface Extentions<T>
	{
		IEnumerable<T> Where(IEnumerable<T> source, Func<T, bool> predicate);

	}
	class ZooRepo : IZooRepo
	{
		private List<Animal> _animals;

		public ZooRepo()
		{
			_animals = new List<Animal>();
			_animals.Add(new Lion("leo") { State=AnimalState.Patient});
			_animals.Add(new Tiger("timur"));
			_animals.Add(new Elephant("slo"));
			_animals.Add(new Bear("white"));
			_animals.Add(new Wolf("seryj"));
			_animals.Add(new Fox("red"));

			Random rnd = new Random();
			int count = 0;
			for (int i = 0; i < 100; i++)
			{
				count = rnd.Next(1,6);
				_animals.Add(AnimalFactory.GetAnimal((AnimalType)count, "animal" + i));
			}
		}

		public IEnumerable<Animal> GetAnimals()
		{
			return _animals;
		}
	}

	public static class Extentions
	{
		public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			foreach (var item in source)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
		}
	}
}
