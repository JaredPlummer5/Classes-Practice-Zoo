using System;
namespace Classes_Practice_Zoo.Classes
{
	public class Monkey : Mammal
	{
		public Monkey()
		{
		}

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

        public override void Walk()
        {
			Console.WriteLine("Walking on my paws");
        }
    }
}

