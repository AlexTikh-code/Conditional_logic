
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



for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($" Iteration: {i}");
}
for (int i = 5; i >= 0; i--)
{
    Console.WriteLine($" Iteration: {i}");
}
for(int i = 2; i <= 10; i=i+2)
{
    Console.WriteLine($"{i}");
}


int n = 1;
int num = int.Parse(Console.ReadLine());
while (n <= num)
{
    Console.WriteLine($"Iteration: {n}");
    n++;
}

string? password;
int attempts = 0;
do
{
    attempts++;
    if (attempts >= 4)
    {
        break;
    }
    Console.Write("Enter your password: ");
    password = Console.ReadLine();
} while (password != "humber2026");
if(password == "humber2026")
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("Access denied.");
}



string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
};

foreach (string dayName in days)
{
    Console.WriteLine(dayName);
}