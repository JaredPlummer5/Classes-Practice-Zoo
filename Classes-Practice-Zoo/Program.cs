namespace Classes_Practice_Zoo;
using Classes_Practice_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Animal Pig = new Animal();
        Pig.Name = "Porky";
        Pig.Legs = 4;
        Pig.Color = "Pink";
        Pig.IsEating = true;
        

        Console.WriteLine($"This animal is a pig. {Pig.Name} is {Pig.Color}. ....Is Eating? {Pig.IsEating} .....Is Sleepinging? {Pig.IsSleeping}");


        Animal Lizard = new Animal();
        Lizard.Name = "Liz";
        Lizard.Color = "Green";
        Lizard.IsSleeping = true;

        Console.WriteLine($"This animal is a pig. {Lizard.Name} is {Pig.Color}. ....Is Eating? {Lizard.IsEating} .....Is Sleepinging? {Lizard.IsSleeping}");

        Animal TrytaraHoneyBager = new Animal();
        TrytaraHoneyBager.Name = "Tracey";
        TrytaraHoneyBager.Color = "Gray";
        TrytaraHoneyBager.IsSleeping = true;

        Console.WriteLine($"This animal is a pig. {TrytaraHoneyBager.Name} is {TrytaraHoneyBager.Color}. ....Is Eating? {TrytaraHoneyBager.IsEating} .....Is Sleepinging? {TrytaraHoneyBager.IsSleeping}");


        Console.ReadLine();
    }

}

