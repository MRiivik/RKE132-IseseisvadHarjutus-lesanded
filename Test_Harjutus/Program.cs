int num;
// Kasutaja sisestab arvu
Console.Write("Enter a number to check if it's even or odd:");

num = Convert.ToInt32(Console.ReadLine());

switch (num % 2)
{
    // If n%2 == 0
    case 0:
        Console.WriteLine(num + " is an even number");
        break;

    //Else if n%2 == 1
    case 1:
        Console.WriteLine(num + " is an odd number");
        break;
}