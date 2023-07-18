using System;
namespace Classes_Practice_Zoo.Classes
{
    public class Rhino : Mammal
	{
		public Rhino()
		{
		}
            public void Charge()
			{

				Console.WriteLine("The Rhino is charging!!!!");

			}

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am a rhino");
        }

        public override void Sound()
        {
            Console.WriteLine("Grrrrr");
        }

        public override void Walk()
        {
            Console.WriteLine("I'm a rhino and I'm walking");
        }
    }
}

