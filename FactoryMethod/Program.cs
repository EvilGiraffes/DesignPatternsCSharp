using FactoryMethod;

using Internals;

string folder = Directory.GetCurrentDirectory();
string filename = "MyVideoFile";
string prompt = "Please input your quality >> ";
StringComparer comparer = StringComparer.OrdinalIgnoreCase;
Dictionary<string, IVideoSaverFactory> factories = new(comparer)
{
    { "low", new FastSaverFactory() },
    { "high", new HDSaverFactory() },
    { "master", new FourKSaverFactory() }
};
Console.Write(prompt);
if (!InputHelper.TryGetInput(factories.Keys, comparer, out string? input))
{
    string inputMessage = input is null ? "null" : input;
    Console.WriteLine($"Invalid input was given, got {inputMessage}");
    return;
}
IVideoSaverFactory factory = factories[input];
IVideoSaver saver = factory.Create();
VideoDataContainer data = new("Placeholder video data.", "Placeholder audio data.");
saver.Save(data, folder, filename);
VideoDataContainer retrievedData = saver.Load(folder, filename);
Console.WriteLine(retrievedData);
