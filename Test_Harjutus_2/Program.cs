string userPIN;
Console.WriteLine("Enter your pin:");
while (true)
{
    userPIN = Console.ReadLine();
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
            break;
    }
    else
    {
        Console.WriteLine("Wrong PIN, try again.");
    }
}