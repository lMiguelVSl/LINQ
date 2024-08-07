using System.Collections;
using LINQ_Course.Entities;

namespace LINQ_Course.Methods;

public static class LinqAny
{
    public static void IsAnyLargerThan4()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };
        var isAnyLargerThan4 = numbers.Any(n => n > 4);
        Console.WriteLine($" isAnyLargerThan 4: {isAnyLargerThan4}");
    }

    public static void IsAnyPetNamed(string name)
    {
        var pets = new[]
        {
            new Pet { Id = 1, Name = "Fluffy", PetType = "Cat", Height = 9.1 },
            new Pet { Id = 2, Name = "Rover", PetType = "Dog", Height = 13.2 }
        };
        var isAnyPetNamed = pets.Any(p => p.Name == name);
        Console.WriteLine($" isAnyPetNamedRover: {isAnyPetNamed}");
    }

    public static void IsNotEmpty(IEnumerable<object> list)
    {
        var isNotEmpty = list.Any();
        Console.WriteLine($" isNotEmpty: {isNotEmpty}");
    }
}