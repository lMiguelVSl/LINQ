using LINQ_Course.Entities;

namespace LINQ_Course.Methods;

public class MinMax
{
    public void GetMinMaxNum(IList<int> numbers)
    {
        var min = numbers.Min();
        var max = numbers.Max();
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
    
    public void GetMinMaxPetHeight(IList<Pet> pets)
    {
        var min = pets.Min(p => p.Height);
        var max = pets.Max(p => p.Height);
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}