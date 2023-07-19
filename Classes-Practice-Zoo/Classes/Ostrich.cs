using System;
using Classes_Practice_Zoo.Interfaces;

namespace Classes_Practice_Zoo.Classes
{
	public class Ostrich : Birds, IWalks
    {
		public Ostrich()
		{
		}

        public int Legs { get; set; }

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am a Ostrich");
        }

        public override void Sound()
        {
            Console.WriteLine("Ostrich sound");
        }

        public void Walk()
        {
            Console.WriteLine("ZOOOM!!!");
        }
    }
}

