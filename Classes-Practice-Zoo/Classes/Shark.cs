using System;
namespace Classes_Practice_Zoo.Classes
{
	public class Shark : Fish
	{
		public Shark()
		{
		}

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am a shark");
        }

        public override void Sound()
        {
            Console.WriteLine("Gargle gargle garlge");
        }
    }
}

