//Welcome message
Console.WriteLine("Order Please");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.Write("Enter your desired order: ");
string? order = Console.ReadLine();
string response;

//Show response
Console.WriteLine($"Your order is {order}.");

if (order.ToLower() == "anything")
{
    response = "It will be delivered anytime.";
}
else
{
    response = "We don't have that in the list.";
}

Console.WriteLine(response);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();