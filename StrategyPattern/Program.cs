using System.Text;

using StrategyPattern;

const int amount = 10;

Random random = new();
ISortStrategy<int>[] sorters =
{
    new FirstInFirstOut<int>(),
    new FirstInLastOut<int>(),
    new FirstInRandomOut<int>(random)
};
List<int> testingArray = Enumerable.Range(1, amount).ToList();
foreach (ISortStrategy<int> sorter in sorters)
{

    Stack<int> sorted = sorter.Sort(testingArray);
    StringBuilder builder = new();
    builder
        .Append("[ ")
        .AppendJoin(", ", sorted)
        .Append(" ]");
    Console.WriteLine(sorter.GetType().Name);
    Console.WriteLine(builder.ToString());
    Console.WriteLine();
}
