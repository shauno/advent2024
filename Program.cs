
using advent.Days;

Console.WriteLine("Enter Day Number:");
string? day = Console.ReadLine();

try
{
    int result = Int32.Parse(day);

    if (result < 1 || result > 31) {
        throw new FormatException();
    }

    // Probably should look at dynamically calling $"Day{day}.Answer()" or something
    switch (result)
    {
        case 1:
            Console.WriteLine($"Answer: {Day1.Answer()}");
            break;
        default:
            Console.WriteLine("Not implemented yet, be patient.");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter an integer between 1 and 31");
}



