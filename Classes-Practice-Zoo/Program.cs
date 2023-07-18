namespace Classes_Practice_Zoo;
using Classes_Practice_Zoo;
using Classes_Practice_Zoo.Classes;

class Program
{
    static void Main(string[] args)
    {

        Rhino rhino = new Rhino();
        rhino.I_am_a_Animal();
        rhino.Charge();
        rhino.Sleep();
        rhino.Eat();


        Monkey monkey = new Monkey();
        monkey.I_am_a_Animal();
        monkey.ClimbingTree();
        monkey.Eat();
        monkey.Sleep();

        Shark shark = new Shark();
        shark.I_am_a_Animal();
        shark.Eat();
        shark.Sleep();
        shark.Sound();

        Flamingo flamingo = new Flamingo();
        flamingo.I_am_a_Animal();
        flamingo.Sleep();
        flamingo.Eat();
        flamingo.Sound();

        
        Eagle eagle = new Eagle();
        eagle.I_am_a_Animal();
        eagle.Sound();
        eagle.Eat();
        eagle.Sleep();


        Console.ReadLine();
        //Animal Pig = new Animal();
        //Pig.Name = "Porky";
        //Pig.Legs = 4;
        //Pig.Color = "Pink";
        //Pig.IsEating = true;


        //Console.WriteLine($"This animal is a pig. {Pig.Name} is {Pig.Color}. ....Is Eating? {Pig.IsEating} .....Is Sleepinging? {Pig.IsSleeping}");


        //Animal Lizard = new Animal();
        //Lizard.Name = "Liz";
        //Lizard.Color = "Green";
        //Lizard.IsSleeping = true;

        //Console.WriteLine($"This animal is a pig. {Lizard.Name} is {Pig.Color}. ....Is Eating? {Lizard.IsEating} .....Is Sleepinging? {Lizard.IsSleeping}");

        //Animal TrytaraHoneyBager = new Animal();
        //TrytaraHoneyBager.Name = "Tracey";
        //TrytaraHoneyBager.Color = "Gray";
        //TrytaraHoneyBager.IsSleeping = true;

        //Console.WriteLine($"This animal is a pig. {TrytaraHoneyBager.Name} is {TrytaraHoneyBager.Color}. ....Is Eating? {TrytaraHoneyBager.IsEating} .....Is Sleepinging? {TrytaraHoneyBager.IsSleeping}");


        //Console.ReadLine();
    }

    //public static string animalI(string testInput)
    //{
    //    Animal inout = new Animal();


    //}

}

