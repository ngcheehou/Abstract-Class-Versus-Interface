
//This project shows a scenario where Interface has more advantage against Abstract Class.

IFlyable flyD = new FlyingDrone();
flyD.Fly();


//SwimmingDrone swmD = new SwimmingDrone();
//swmD.Swim();

//MultiPurposeDrone multiD = new MultiPurposeDrone();
//multiD.Fly();
//multiD.Swim();

//AbstractFlyingDrone abstractflyingdrone = new AbstractFlyingDrone();
//abstractflyingdrone.Fly(); 

//AbstractSwimmingDrone abstractswimmingdrone = new AbstractSwimmingDrone();
//abstractswimmingdrone.Swim();


//NewAbstractMultiPurposeDroneThatCanSpeak abstractmultipurposedrone = new NewAbstractMultiPurposeDroneThatCanSpeak();
//abstractmultipurposedrone.Fly();
//abstractmultipurposedrone.Swim();
//abstractmultipurposedrone.Speak();


// MilitaryDrone militaryDrone = new MilitaryDrone();
//militaryDrone.Fly();
//militaryDrone.CarryMissle();

Console.ReadLine();


interface IFlyable
{
    void Fly();//fly feature
    void CarryMissle() => Console.WriteLine($"Drone is firing a missle!");
}

interface ISwimmable
{
    void Swim();//swim feature
}


interface ISpeakable
{
    void Speak();//speaking feature
    
}

class FlyingDrone: IFlyable
{
    public void Fly() => Console.WriteLine("Drone is flying");

    //Doesn't need implement CarryMissle() since this version drone is civilian use
}

class SwimmingDrone : ISwimmable
{
    public void Swim() => Console.WriteLine("Drone is swimming");
}


class MultiPurposeDrone : IFlyable, ISwimmable, ISpeakable
{
    public void Fly() => Console.WriteLine("Multi purpose Drone is flying");

    public void Swim() => Console.WriteLine("Multi purpose Drone is swimming");

    public void Speak() => Console.WriteLine("Hello world I can speak now!");

    //Doesn't need implement CarryMissle() since this version drone is civilian use
}





class MilitaryDrone : IFlyable 
{
    public void Fly() => Console.WriteLine("Military drone is flying"); 

    public void CarryMissle() => Console.WriteLine($"Military drone is firing air to ground missle");

}


#region Abstract class example
public abstract class AbstractDrone
{
    public virtual void Fly() { }

    public virtual void Swim() { }
    public virtual void Speak() { }//new line

}


public class AbstractFlyingDrone : AbstractDrone {

    public override void Fly()
    {
        Console.WriteLine("Drone is flying");
    }

}

public class AbstractSwimmingDrone : AbstractDrone
{

    public override void Swim()
    {
        Console.WriteLine("Drone is swimming");
    }

}

public class AbstractMultiPurposeDrone : AbstractDrone
{
    public override void Fly()
    {
        Console.WriteLine("Multi purpose Drone is flying");
    }

    public override void Swim()
    {
        Console.WriteLine("Multi purpose Drone is swimming");
    }

}

public class NewAbstractMultiPurposeDroneThatCanSpeak : AbstractMultiPurposeDrone
{
    public override void Fly()
    {
        Console.WriteLine("Multi purpose Drone is flying");
    }

    public override void Swim()
    {
        Console.WriteLine("Multi purpose Drone is swimming");
    }

    public override void Speak()
    {
        Console.WriteLine("Hello world I can speak!");
    }


}

#endregion