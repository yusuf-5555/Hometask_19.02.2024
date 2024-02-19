System.Console.Write("From : ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("To : ");
int y = Convert.ToInt32(Console.ReadLine());
for(int i = x; i<=y;i++)
{
    System.Console.WriteLine("----------------");
    for(int j=1;j<=10;j++)
    {
        System.Console.WriteLine(i + "*" + j + "=" + i*j);
    }
    System.Console.WriteLine("----------------");
}