using LINQ_Course.Methods;

//Any method
Console.WriteLine("Any method");
LinqAny.IsAnyLargerThan4();
LinqAny.IsAnyPetNamed("Rover");
Console.WriteLine(" ");

//All method
Console.WriteLine("All method");
LinqAll.AreNamesValid();
Console.WriteLine(" ");

//OrderBy method
Console.WriteLine("OrderBy method");
LinqOrderBy.OrderByName();
LinqOrderBy.OrderByNameDescending();
Console.WriteLine(" ");