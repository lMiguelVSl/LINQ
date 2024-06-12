using LINQ_Course.Entities;

var numbers = new[] {1, 2, 3, 4, 5};
var isAnyLargerThan4 = numbers.Any(n => n > 4);
Console.WriteLine($" isAnyLargerThan 4: {isAnyLargerThan4}");

var pets = new[]
{
    new Pet { Id = 1, Name = "Fluffy", PetType = "Cat", Height = 9.1 },
    new Pet { Id = 2, Name = "Rover", PetType = "Dog", Height = 13.2 }
};
var isAnyPetNamedRover = pets.Any(p => p.Name == "Rover");
Console.WriteLine($" isAnyPetNamedRover: {isAnyPetNamedRover}");

var isNotEmpty = pets.Any();
Console.WriteLine($" isNotEmpty: {isNotEmpty}");
var names = new[] {"Bob", "Mavs", "Gregggggggggggggggggggggggggggggg"};
var areAllNamesValid = names.All(n => char.IsLower(n[0]) && n.Length is > 2 and < 25);
Console.WriteLine($" areAllNamesValid: {areAllNamesValid}");