using LINQ_Course.Entities;

namespace LINQ_Course.Methods;

public static class LinqOrderBy
{
    public static void OrderByName()
    {
        var pets = new[]
        {
            new Pet { Id = 1, Name = "Fluffy", PetType = "Cat", Height = 9.1 },
            new Pet { Id = 2, Name = "Rover", PetType = "Dog", Height = 13.2 }
        };
        var orderedPets = pets.OrderBy(p => p.Name);
        foreach (var pet in orderedPets)
        {
            Console.WriteLine($"Pet: {pet.Name}");
        }
    }
    
    public static void OrderByNameDescending()
    {
        var pets = new List<Pet>
        {
            new() { Id = 1, Name = "Fluffy", PetType = "Cat", Height = 9.1 },
            new() { Id = 2, Name = "Rover", PetType = "Dog", Height = 13.2 }
        };
        var orderedPets = pets.OrderByDescending(p => p.Name);
        foreach (var pet in orderedPets)
        {
            Console.WriteLine($"Pet: {pet.Name}");
        }
    }
}