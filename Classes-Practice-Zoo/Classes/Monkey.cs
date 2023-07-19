using System;
using Classes_Practice_Zoo.Interfaces;

namespace Classes_Practice_Zoo.Classes
{
	public class Monkey : Mammal, IWalks
	{
		public Monkey()
		{
		}

        public int Legs { get ; set; }

        public void ClimbingTree()
		{

			Console.WriteLine("THe monkey is climbing the tree");
		}

        public override void I_am_a_Animal()
        {
			Console.WriteLine("I am a Monkey");
        }

        public override void Sound()
		{
			Console.WriteLine("Ooo Ooo Ahh AHh");

		}

        public void Walk()
        {
			Legs = 4;
			Console.WriteLine("Walking on my paws with {0} legs", Legs);
        }
    }
}

