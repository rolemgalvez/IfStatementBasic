//Welcome message
Console.WriteLine("Possibility");
Console.WriteLine("-----------");
Console.WriteLine();

//Get user input
Console.Write("Enter such possiblity: ");
string? possibility = Console.ReadLine();
Console.WriteLine();

//Show values
Console.WriteLine($"Your given answer is {possibility}");
if (possibility?.ToLower() == "anything")
{
    Console.WriteLine("That's right! Anything is possible.");
}
else
{
    Console.WriteLine("Interesting. I didn't expect that.");
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();