namespace FactoryMethod;
public sealed class HDSaverFactory : IVideoSaverFactory
{
    public IVideoSaver Create()
    {
        Log();
        return new HDSaver();
    }
    static void Log()
        => Console.WriteLine($"Creating {typeof(HDSaver).Name} from {typeof(HDSaverFactory).Name}.");
}
