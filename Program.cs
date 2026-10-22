
Console.Write("Enter your average mark in %: ");
var mark = int.Parse(Console.ReadLine());

if(mark >= 90)
{
    Console.WriteLine("You have admission and scholarship.");
}
else if (mark >= 75)
{
    Console.WriteLine("You have regular admission.");
}
else if (mark >= 60)
{
    Console.WriteLine("You have conditional admission.");
}
else 
{
    Console.WriteLine("You do not addmited");
}

string? label = mark >= 50 ? "Pass" : "Fail";

Console.WriteLine("Enter week day (1-7): ");
var day = int.Parse(Console.ReadLine());

switch(day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day.");
        break;
}
