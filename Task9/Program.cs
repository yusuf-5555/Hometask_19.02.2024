using System.Security.Cryptography;

int Exponent(int a, int b)
{
    if(b==1)return a;
    else
    {
        b--;
        return a*Exponent(a,b);
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Exponent(a,b));