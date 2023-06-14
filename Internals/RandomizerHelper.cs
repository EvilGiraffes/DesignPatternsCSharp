namespace Internals;

public static class RandomizerHelper
{
    public static int IndexOf<T>(this Random random, IReadOnlyList<T> values)
        => random.Next(0, values.Count);
    public static T Choice<T>(this Random random, IReadOnlyList<T> values)
        => values[random.IndexOf(values)];
}
