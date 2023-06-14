namespace Internals;
public sealed class InputListHandler
{
    readonly string prompt;
    readonly HashSet<string> expectedInputs;
    readonly StringComparer comparer;
    readonly int? maxRetries;
    const string Exit = "exit";

    public InputListHandler(string prompt, IEnumerable<string> expectedInputs, StringComparer comparer, int? maxRetries = null)
    {
        this.prompt = prompt;
        this.expectedInputs = new(expectedInputs, comparer);
        this.comparer = comparer;
        this.maxRetries = maxRetries;
    }
    public string? Get()
    {
        int runs = 0;
        while (true)
        {
            if (maxRetries is not null && runs >= maxRetries)
                return null;
            runs++;
            Console.WriteLine($"Choices: {Choices()}.");
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (input is null)
                return null;
            if (comparer.Equals(input, Exit))
                return null;
            if (!expectedInputs.Contains(input))
            {
                HandleUnexpectedInput(input);
                continue;
            }
            return input;
        }
    }
    string Choices()
        => string.Join(", ", expectedInputs);
    void HandleUnexpectedInput(string given)
        => Console.WriteLine($"Invalid input. You gave {given}, but your choices are {Choices()}.");
}
