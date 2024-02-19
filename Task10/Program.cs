int Fib(int n)
{
    if(n==0 || n==1)
    return n;
else
{
    return Fib(n-1)+Fib(n-2);
}
}
System.Console.Write("Input number of terms for the Fibonacci series : ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("The Fibonacci series of 10 terms is : ");
for (int i = 0; i < n; i++)
{
    System.Console.Write(Fib(i)+" ");
}