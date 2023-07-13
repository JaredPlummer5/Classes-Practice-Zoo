using System;
namespace Classes_Practice_Zoo
{
	
	public class Animal
	{
		public string? Name { get; set; }
		public string? Color { get; set; }
		public int Legs { get; set; }
		public bool IsEating { get; set; }
		public bool IsSleeping { get; set; }

		//public Animal(string name, string color, int legs)
		//{
		//	Name = name;
		//	Color = color;
		//	Legs = legs;

			
		//}


  //      public Animal()
  //      {
  //      }

        public bool Eating()
		{
			IsEating = true;
           
			return IsEating;


        }

		public bool Sleeping()
		{

			IsSleeping = true;
			
			return IsSleeping;

        }
	}
}

