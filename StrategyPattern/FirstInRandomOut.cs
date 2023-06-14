using Internals;

namespace StrategyPattern;
public sealed class FirstInRandomOut<T> : ISortStrategy<T>
{
    readonly Random random;
    public FirstInRandomOut(Random random)
    {
        this.random = random;
    }
    public Stack<T> Sort(IReadOnlyList<T> list)
    {
        List<T> listCopy = new(list);
        Stack<T> result = new(list.Count);
        while (listCopy.Count > 0)
        {
            int index = random.IndexOf(listCopy);
            result.Push(listCopy[index]);
            listCopy.RemoveAt(index);
        }
        return result;
    }
}
