using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
	 class Lion: Animal
	{
		 public Lion(string alias)
			 : base(alias)
		 {
			 MaxHealth = 5;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Lion;
		 }
	}
	 class Tiger:Animal
	 {
		 public Tiger(string alias)
			 : base(alias)
		 {
			 MaxHealth = 4;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Tiger;
		 }
	 }
	 class Elephant:Animal
	 {
		 public Elephant(string alias)
			 : base(alias)
		 {
			 MaxHealth = 7;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Elephant;
		 }
	 }
	 class Bear:Animal
	 {
		 public Bear(string alias)
			 : base(alias)
		 {
			 MaxHealth = 6;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Bear;
		 }
	 }

	 class Wolf:Animal
	 {
		 public Wolf(string alias)
			 : base(alias)
		 {
			 MaxHealth = 4;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Wolf;
		 }
	 }
	 class Fox : Animal
	 {
		 public Fox(string alias)
			 : base(alias)
		 {
			 MaxHealth = 3;
			 Health = MaxHealth;
			 AnimalType = AnimalType.Fox;
		 }
	 }

}
