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

        Console.WriteLine("=======================");
        Monkey monkey = new Monkey();
        monkey.I_am_a_Animal();
        monkey.ClimbingTree();
        monkey.Eat();
        monkey.Sleep();
        Console.WriteLine("=======================");

        Shark shark = new Shark();
        shark.I_am_a_Animal();
        shark.Eat();
        shark.Sleep();
        shark.Sound();
        shark.Swimming();
        Console.WriteLine("=======================");

        Flamingo flamingo = new Flamingo();
        flamingo.I_am_a_Animal();
        flamingo.Sleep();
        flamingo.Eat();
        flamingo.Sound();

        Console.WriteLine("=======================");

        Eagle eagle = new Eagle();
        eagle.I_am_a_Animal();
        eagle.Sound();
        eagle.Eat();
        eagle.Sleep();
        Console.WriteLine("=======================");


        Console.ReadLine();
    }


}

