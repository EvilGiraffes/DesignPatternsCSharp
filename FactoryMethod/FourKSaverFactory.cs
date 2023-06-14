namespace FactoryMethod;
public sealed class FourKSaverFactory : IVideoSaverFactory
{
    public IVideoSaver Create()
    {
        Log();
        return new FastSaver();
    }
    static void Log()
        => Console.WriteLine($"Creating {typeof(FourKSaver).Name} from {typeof(FourKSaverFactory).Name}.");
}
