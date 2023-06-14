using System.Runtime.CompilerServices;

namespace FactoryMethod;
public sealed class HDSaver : IVideoSaver
{
    VideoDataContainer data;
    public VideoDataContainer Load(string folder, string fileName)
    {
        Log(folder, fileName);
        return data;
    }
    public void Save(VideoDataContainer data, string folder, string filename)
    {
        Log(folder, filename);
        this.data = data;
    }
    static void Log(string folder, string fileName, [CallerMemberName] string? method = null)
        => Console.WriteLine($"Calling method {method} from {typeof(HDSaver).Name} with folder {folder} and filename {fileName}.");
}
