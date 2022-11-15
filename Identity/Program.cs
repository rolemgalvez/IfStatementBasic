//Welcome message
Console.WriteLine("Identity");
Console.WriteLine("--------");
Console.WriteLine();

//Get user input
Console.Write("Who are you: ");
string? identity = Console.ReadLine();
Console.WriteLine();

//Show values
Console.WriteLine($"You said you are {identity}");
if (identity?.ToLower() == "anyone")
{
    Console.WriteLine("You are the one we are looking for!");
}
else
{
    Console.WriteLine("Amazing! We just met now.");
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();