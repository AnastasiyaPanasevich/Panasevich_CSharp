internal static class InputParser
{
    public static bool TryParseInt(string token, out int result)
        => int.TryParse(token, out result);

    public static bool TryParseName(string token, out string name)
    {
        name = token;
        return token.All(IsNameChar);
    }

    public static bool IsFloatLike(string token)
    {
        string t = token.StartsWith('-') ? token[1..] : token;

        int separatorIndex = t.IndexOfAny(['.', ',']);
        if (separatorIndex <= 0 || separatorIndex >= t.Length - 1)
            return false;

        char separator = t[separatorIndex];
        if (t.Count(c => c == separator) != 1)
            return false;

        return t.Replace(".", "").Replace(",", "").All(char.IsDigit);
    }

    public static bool IsOutOfIntRange(string token, out bool isBelowMin)
    {
        isBelowMin = false;
        string t = token.StartsWith('-') ? token[1..] : token;

        if (t.Length == 0 || !t.All(char.IsDigit))
            return false;

        if (!long.TryParse(token, out long value))
        {
            isBelowMin = token.StartsWith('-');
            return true;
        }

        isBelowMin = value < int.MinValue;
        return value > int.MaxValue || value < int.MinValue;
    }

    public static bool IsNameChar(char c)
        => char.IsLetter(c) || c == '-' || c == '\'';
}