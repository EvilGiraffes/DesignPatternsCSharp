public interface IFlyStrategy
{
    void Fly();
}
public class CantFly: IFlyStrategy
{
    public void Fly() => Console.WriteLine("I have no wings bitrch");
}
public class RegularFlight: IFlyStrategy
{
    public void Fly() => Console.WriteLine("I flying like a basic bitch");
}
public class FliesHigh: IFlyStrategy
{
    public void Fly() => Console.WriteLine("I am tall");
}
public abstract class Animal
{
    protected abstract IFlyStrategy FlyStrategy { get; }
    public abstract void MakeSound();
    public void Fly() => FlyStrategy.Fly();
}
public class Hippo: Animal
{
    protected override IFlyStrategy FlyStrategy => new CantFly();
    public override void MakeSound()
    {
        Console.WriteLine("moooooo");
    }
}
public class Bord: Animal
{
    protected override IFlyStrategy FlyStrategy => new RegularFlight();
    public override void MakeSound()
    {
        Console.WriteLine("tall mooo");
    }
}
public class WeedBord: Animal
{
    protected override IFlyStrategy FlyStrategy => new FliesHigh();
    public override void MakeSound()
    {
        Console.WriteLine("hi high how officer are you");
    }
}