//Welcome message
Console.WriteLine("Where It Is");
Console.WriteLine("-----------");
Console.WriteLine();

//Get user input
Console.Write("Tell me where you put it: ");
string? location = Console.ReadLine();
Console.WriteLine();

//Show values
Console.WriteLine($"You said it is at {location}");
if (location?.ToLower() == "anywhere")
{
    Console.WriteLine("I knew It! It is at anywhere.");
}
else
{
    Console.WriteLine("I will put that in mind.");
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();