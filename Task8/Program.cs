using System.Diagnostics.CodeAnalysis;

int Sum(int a, int b)
{System.Console.Write(a + " + " + b + " = ");
    return a+b;
}
int Subtract(int a, int b)
{System.Console.Write(a + " - " + b + " = ");
    return a-b;
}
int Multiplication(int a, int b)
{System.Console.Write(a + " * " + b + " = ");
    return a*b;
}
int Division(int a, int b)
{System.Console.Write(a + " / " + b + " = ");
    return a/b;
}
int a = Convert.ToInt32(Console.ReadLine());
char c = Convert.ToChar(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(c=='+')System.Console.WriteLine(Sum(a,b));
if(c=='-')System.Console.WriteLine(Subtract(a,b));
if(c=='*')System.Console.WriteLine(Multiplication(a,b));
if(c=='/')System.Console.WriteLine(Division(a,b));
