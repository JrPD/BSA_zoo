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
		 }
	}
	 class Tiger:Animal
	 {
		 public Tiger(string alias)
			 : base(alias)
		 {
			 MaxHealth = 4;
			 Health = MaxHealth;
		 }
	 }
	 class Elephant:Animal
	 {
		 public Elephant(string alias)
			 : base(alias)
		 {
			 MaxHealth = 7;
			 Health = MaxHealth;
		 }
	 }
	 class Bear:Animal
	 {
		 public Bear(string alias)
			 : base(alias)
		 {
			 MaxHealth = 6;
			 Health = MaxHealth;
		 }
	 }

	 class Wolf:Animal
	 {
		 public Wolf(string alias)
			 : base(alias)
		 {
			 MaxHealth = 4;
			 Health = MaxHealth;
		 }
	 }
	 class Fox : Animal
	 {
		 public Fox(string alias)
			 : base(alias)
		 {
			 MaxHealth = 3;
			 Health = MaxHealth;
		 }
	 }

}
