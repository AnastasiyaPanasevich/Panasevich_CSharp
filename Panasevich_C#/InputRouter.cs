internal static class InputRouter
{
    public static string Route(string[] tokens)
    {
        if (tokens.Length == 0)
            throw new AppException("No input provided.");

        if (tokens.Length == 1)
        {
            string token = tokens[0];

            if (InputParser.IsFloatLike(token) || InputParser.IsOutOfIntRange(token, out _))
            {
                InputValidator.ValidateIntToken(token);
            }

            if (InputParser.TryParseInt(token, out int number))
                return Algorithms.CheckNumber(number);

            if (InputParser.TryParseName(token, out string name))
                return Algorithms.GreetByName(name);

            throw new AppException(
                $"'{token}' is not a valid number or name. " +
                "A name should contain only letters. An array should be integers separated by spaces.");
        }

        int[] numbers = InputValidator.ParseValidIntArray(tokens);
        return Algorithms.FilterMultiplesOfThree(numbers);
    }
}