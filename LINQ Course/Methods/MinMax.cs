using LINQ_Course.Entities;

namespace LINQ_Course.Methods;

public static class MinMax
{
    public static void GetMinMaxNum()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var min = numbers.Min();
        var max = numbers.Max();
        Console.WriteLine($"Num Min: {min}, Num Max: {max}");
    }
    
    public static void GetMinMaxPetHeight()
    {
        var pets = new List<Pet>
        {
            new() { Name = "Barley", Height = 0.63 },
            new() { Name = "Boots", Height = 0.33 },
            new() { Name = "Whiskers", Height = 0.09 }
        };
        var min = pets.Min(p => p.Height);
        var max = pets.Max(p => p.Height);
        Console.WriteLine($"Height Min: {min}, Height Max: {max}");
    }
}