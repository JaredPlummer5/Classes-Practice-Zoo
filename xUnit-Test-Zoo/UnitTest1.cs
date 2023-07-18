using Xunit;
using System.IO;
using Classes_Practice_Zoo;
using Classes_Practice_Zoo.Classes;

public class AnimalTests
{
    [Fact]
    public void CanEagleSleep()
    {
        // Arrange
        Eagle eagle = new Eagle();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        eagle.Sleep();

        // Assert
        Assert.Contains("ZZZZZZZZZ", stringWriter.ToString());
    }

    [Fact]
    public void CanEagleEat()
    {
        // Arrange
        Eagle eagle = new Eagle();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        eagle.Eat();

        // Assert
        Assert.Contains("I'm eating", stringWriter.ToString());
    }

    [Fact]
    public void CanEagleMakeASound()
    {
        Eagle eagle = new Eagle();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        eagle.Sound();
        Assert.Contains("Caww Caww!!!!", stringWriter.ToString());
    }

    [Fact]
    public void CanFlamingoSleep()
    {
        // Arrange
        Flamingo flamingo = new Flamingo();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        flamingo.Sleep();

        // Assert
        Assert.Contains("ZZZZZZZZZ", stringWriter.ToString());
    }

    [Fact]
    public void CanFlamingoEat()
    {
        // Arrange
        Flamingo flamingo = new Flamingo();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        flamingo.Eat();

        // Assert
        Assert.Contains("I'm eating", stringWriter.ToString());
    }

    [Fact]
    public void CanFlamingoMakeASound()
    {
        Flamingo flamingo = new Flamingo();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        flamingo.Sound();
        Assert.Contains("Eep Eepp Eepp", stringWriter.ToString()); // adjust the expected sound
    }


    [Fact]
    public void CanSharkSleep()
    {
        // Arrange
        Shark shark = new Shark();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        shark.Sleep();

        // Assert
        Assert.Contains("ZZZZZZZZZ", stringWriter.ToString());
    }

    [Fact]
    public void CanSharkEat()
    {
        // Arrange
        Shark shark = new Shark();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        shark.Eat();

        // Assert
        Assert.Contains("I'm eating", stringWriter.ToString());
    }

    [Fact]
    public void CanSharkMakeASound()
    {
        Shark shark = new Shark();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        shark.Sound();
        Assert.Contains("Gargle gargle garlge", stringWriter.ToString()); // adjust the expected sound
    }

    [Fact]
    public void CanMonkeySleep()
    {
        // Arrange
        Monkey monkey = new Monkey();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        monkey.Sleep();

        // Assert
        Assert.Contains("ZZZZZZZZZ", stringWriter.ToString());
    }

    [Fact]
    public void CanMonkeyEat()
    {
        // Arrange
        Monkey monkey = new Monkey();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        monkey.Eat();

        // Assert
        Assert.Contains("I'm eating", stringWriter.ToString());
    }

    [Fact]
    public void CanMonkeyMakeASound()
    {
        Monkey monkey = new Monkey();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        monkey.Sound();
        Assert.Contains("Ooo Ooo Ahh AHh", stringWriter.ToString()); // adjust the expected sound
    }

    [Fact]
    public void CanRhinoSleep()
    {
        // Arrange
        Rhino rhino = new Rhino();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        rhino.Sleep();

        // Assert
        Assert.Contains("ZZZZZZZZZ", stringWriter.ToString());
    }

    [Fact]
    public void CanRhinoEat()
    {
        // Arrange
        Rhino rhino = new Rhino();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        rhino.Eat();

        // Assert
        Assert.Contains("I'm eating", stringWriter.ToString());
    }

    [Fact]
    public void CanRhinoMakeASound()
    {
        Rhino rhino = new Rhino();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        rhino.Sound();
        Assert.Contains("Grrrrr", stringWriter.ToString()); // adjust the expected sound
    }


}
