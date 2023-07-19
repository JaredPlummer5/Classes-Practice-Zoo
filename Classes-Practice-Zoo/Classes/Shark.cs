using System;
using Classes_Practice_Zoo.Interfaces;

namespace Classes_Practice_Zoo.Classes
{
	public class Shark : Fish, ISwimming
    {
		public Shark()
		{
		}

        public int Gills { get; set; }

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am a shark");
        }

        public override void Sound()
        {
            Console.WriteLine("Gargle gargle garlge");
        }

        public void Swimming()
        {
            Console.WriteLine("I am swimming");
        }
    }
}

