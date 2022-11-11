//Welcome message
Console.WriteLine("Guess What");
Console.WriteLine("-----------");
Console.WriteLine();

//Get user input
Console.Write("Guess what will happen: ");
string? guess = Console.ReadLine();
string response;

//Show response
Console.WriteLine($"Your guess is {guess}.");

if (guess.ToLower() == "something")
{
    response = "What an exact prediction!";
}
else
{
    response = "You have an interesting prediction.";
}

Console.WriteLine(response);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();