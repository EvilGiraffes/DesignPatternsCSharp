namespace StrategyPattern;
public sealed class FirstInFirstOut<T> : ISortStrategy<T>
{
    public Stack<T> Sort(IReadOnlyList<T> list)
    {
        Stack<T> result = new(list.Count);
        for (int i = list.Count - 1; i >= 0; i--)
            result.Push(list[i]);
        return result;
    }
}
