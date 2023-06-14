namespace FactoryMethod;
public sealed class FastSaverFactory : IVideoSaverFactory
{
    public IVideoSaver Create()
    {
        Log();
        return new FastSaver();
    }
    static void Log()
        => Console.WriteLine($"Creating {typeof(FastSaver).Name} from {typeof(FastSaverFactory).Name}.");
}
