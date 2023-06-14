public class Basic<T>
{
    T _argument;
    public Basic(T argument)
    {
        _argument = argument;
    }
}
public interface IThingy
{
    void DoStuff();
}
public class ActualThingy: IThingy
{
    public void DoStuff() => Console.WriteLine("Did stuff");
}
public class ActualThingyButDifferent: IThingy
{
    public void DoStuff() => Console.WriteLine("I did different stuff");
}
public class GenericDoesStuff<T> where T: IThingy
{
    T _argument;
    public GenericDoesStuff(T argument)
    {
        _argument = argument;
    }
    public void Draw() => _argument.DoStuff();
}