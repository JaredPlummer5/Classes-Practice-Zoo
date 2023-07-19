using System;
using Classes_Practice_Zoo.Interfaces;

namespace Classes_Practice_Zoo.Classes
{
	public class Dog : Mammal, IWalks
	{
		public Dog()
		{
        
		}


        public int Legs { get; set; }



        public void Walk()
        {
            Console.WriteLine("Zoooom");
        }


        public override void I_am_a_Animal()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }


    }
}

