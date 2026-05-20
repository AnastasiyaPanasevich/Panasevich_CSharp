internal static class Algorithms
{
    public static string CheckNumber(int number)
    {
        if (number > 7)
            return "Hello";

        return $"{number} is not greater than 7.";
    }

    public static string GreetByName(string name)
    {
        if (name.Equals("John", StringComparison.OrdinalIgnoreCase))
            return "Hello, " + name;

        return "There is no such name";
    }

    public static string FilterMultiplesOfThree(int[] numbers)
    {
        int[] multiples = numbers.Where(n => n % 3 == 0).ToArray();

        if (multiples.Length == 0)
            return "No multiples of 3 found.";

        return "Multiples of 3: " + string.Join(", ", multiples);
    }
}