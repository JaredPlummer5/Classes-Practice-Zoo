using System;
namespace Classes_Practice_Zoo.Classes
{
    public class Eagle : Birds
    {
        public Eagle()
        {
        }

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am an eagle");
        }

        public override void Sound()
        {
            Console.WriteLine("Caww Caww!!!!");
        }

        
    }
}

