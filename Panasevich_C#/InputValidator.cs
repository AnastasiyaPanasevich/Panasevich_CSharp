internal static class InputValidator
{
    public static void ValidateIntToken(string token)
    {
        if (InputParser.IsFloatLike(token))
            throw new AppException(
                $"'{token}' looks like a decimal number. Only whole integers are accepted.");

        if (InputParser.IsOutOfIntRange(token, out bool isBelowMin))
            throw new AppException(isBelowMin
                ? $"'{token}' is too small. Minimum allowed value is {int.MinValue}."
                : $"'{token}' is too large. Maximum allowed value is {int.MaxValue}.");

        if (token.All(InputParser.IsNameChar))
            throw new AppException(
                $"'{token}' is a word, not a number. " +
                "For a list of numbers, all values must be integers.");

        if (!InputParser.TryParseInt(token, out _))
            throw new AppException(
                $"'{token}' is not a valid integer. " +
                "Only whole numbers are accepted (e.g. -1 2 3 4 5).");
    }

    public static int[] ParseValidIntArray(string[] tokens)
    {
        var numbers = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            ValidateIntToken(tokens[i]);
            InputParser.TryParseInt(tokens[i], out numbers[i]);
        }

        return numbers;
    }
}