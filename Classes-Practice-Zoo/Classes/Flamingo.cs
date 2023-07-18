using System;
namespace Classes_Practice_Zoo.Classes
{
    public class Flamingo : Birds
    {
        public Flamingo()
        {

        }

        public override void I_am_a_Animal()
        {
            Console.WriteLine("I am a flamingo");
        }

        public override void Sound()
        {
            Console.WriteLine("Eep Eepp Eepp");
        }
    }
}

