Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());

if (a>0)
{
    string result = "";
    for(int i=1;i<=a;i++)
    {
        if(i%2==0)
        {
            result = result + $"{i}; ";
        }
        
    }
    Console.WriteLine(result);
}
else if (a<=0)
{
    string result = "";
    for(int i=1;i>=a;i--)
    {
        if(i%2==0)
        {
            result = result + $"{i}; ";
        }
        
    }
    Console.WriteLine(result);
}