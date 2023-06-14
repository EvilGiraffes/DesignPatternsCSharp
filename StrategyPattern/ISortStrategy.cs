namespace StrategyPattern;
public interface ISortStrategy<T>
{
    Stack<T> Sort(IReadOnlyList<T> list);
}
