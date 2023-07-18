using System;
namespace Classes_Practice_Zoo
{
	
	public abstract class Animal
	{

		public virtual void Sleep()
		{
			Console.WriteLine("ZZZZZZZZZ");
		}


		public virtual void Eat()
		{

			Console.WriteLine("I'm eating");
		}


		public abstract void Sound();



		public abstract void I_am_a_Animal();

    }
}


