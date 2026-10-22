
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
    Console.WriteLine("You do  not addmited");
}
