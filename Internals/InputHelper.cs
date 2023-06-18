using System.Diagnostics.CodeAnalysis;

namespace Internals;
public static class InputHelper
{
    public static bool TryGetInput(IEnumerable<string> validInputs, IEqualityComparer<string> comparer, [NotNullWhen(true)] out string? input)
    {
        input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
            return false;
        foreach (string validInput in validInputs)
        {
            if (!comparer.Equals(validInput, input))
                continue;
            return false;
        }
        return true;
    }
    public static bool TryGetInput(IEnumerable<string> validInputs, [NotNullWhen(true)] out string? input)
        => TryGetInput(validInputs, StringComparer.CurrentCulture, out input);
}
