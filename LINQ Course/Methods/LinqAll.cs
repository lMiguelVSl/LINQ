namespace LINQ_Course.Methods;

public static class LinqAll
{
    public static void AreNamesValid()
    {
        var names = new[] { "Bob", "Mavs", "Greggggggggggggg" };
        var areAllNamesValid = names.All(n => char.IsLower(n[0]) && n.Length is > 2 and < 15);
        Console.WriteLine($" areAllNamesValid: {areAllNamesValid}");
    }
}