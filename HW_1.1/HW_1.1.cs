Console.WriteLine("Enter the first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine("Numbers are equial");
}
