using FactoryMethod;

using Internals;

string folder = Directory.GetCurrentDirectory();
string filename = "MyVideoFile";
string prompt = "Please input your quality >> ";
int? maxRetries = null;
StringComparer comparer = StringComparer.OrdinalIgnoreCase;
Dictionary<string, IVideoSaverFactory> factories = new(comparer)
{
    { "low", new FastSaverFactory() },
    { "high", new HDSaverFactory() },
    { "master", new FourKSaverFactory() }
};
InputListHandler inputListHandler = new(prompt, factories.Keys, comparer, maxRetries);
string? input = inputListHandler.Get();
if (input is null)
{
    Console.WriteLine("Program exiting...");
    return;
}
IVideoSaverFactory factory = factories[input];
IVideoSaver saver = factory.Create();
VideoDataContainer data = new("Placeholder video data.", "Placeholder audio data.");
saver.Save(data, folder, filename);
VideoDataContainer retrievedData = saver.Load(folder, filename);
Console.WriteLine(retrievedData);
