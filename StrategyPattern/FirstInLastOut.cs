namespace StrategyPattern;
public sealed class FirstInLastOut<T> : ISortStrategy<T>
{
    public Stack<T> Sort(IReadOnlyList<T> list)
    {
        Stack<T> result = new(list.Count);
        foreach (T item in list)
            result.Push(item);
        return result;
    }
}
