int max =0;

Console.WriteLine("Enter the first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    max=a;
}
else
{
    max = b;
}

if (c > max)
{
    max=c;
}

Console.WriteLine($"max = {max}");