Console.WriteLine("QA Automation Trainee Task 1");
Console.WriteLine();
Console.WriteLine("Enter your input and press Enter. The program will:");
Console.WriteLine("  - Print 'Hello' if you enter an integer number greater than 7");
Console.WriteLine("  - Greet you if you enter a single name");
Console.WriteLine("  - Print multiples of 3 if you enter an array of integers, separated by space");
Console.WriteLine("Press Enter on an empty line to exit");
Console.WriteLine();

while (true)
{
    Console.Write("> ");
    string? raw = Console.ReadLine();

if (string.IsNullOrWhiteSpace(raw))
    break;

    string[] tokens = raw.Trim().Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);

    try
    {
        Console.WriteLine(InputRouter.Route(tokens));
    }
    catch (AppException ex)
    {
        Console.WriteLine($"Input error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }

    Console.WriteLine();
}

Console.WriteLine("Goodbye!");