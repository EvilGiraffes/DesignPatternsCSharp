namespace FactoryMethod;
public interface IVideoSaver
{
    void Save(VideoDataContainer data, string folder, string filename);
    VideoDataContainer Load(string folder, string fileName);
}
