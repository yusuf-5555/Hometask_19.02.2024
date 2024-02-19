int EvenCount(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10)
    {
        if((i%10)%2==0)
        {
            cnt++;
        }
    }
    return cnt;
}
int OddCount(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10)
    {
        if((i%10)%2!=0)
        {
            cnt++;
        }
    }
    return cnt;
}
int ZeroCount(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10)
    {
        if((i%10)==0)
        {
            cnt++;
        }
    }
    return cnt;
}
int DigitCount(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10)
    {
        cnt++;
    }
    return cnt;
}
int MinDigit(int n)
{
    int b=99999;
    for(int i=n;i>0;i/=10)
    {
        if(i%10<b)b=i%10;
    }
    return b;
}
int MaxDigit(int n)
{
    int b=-99999;
    for(int i=n;i>0;i/=10)
    {
        if(i%10>b)b=i%10;
    }
    return b;
}
int SumDigits(int n)
{
    int cnt=0;
    for(int i=n;i>0;i/=10)
    {
       cnt = cnt+i%10;
    }
    return cnt;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Even : " + EvenCount(a));
System.Console.WriteLine("Odd : " + OddCount(a));
System.Console.WriteLine("Zero : " + ZeroCount(a));
System.Console.WriteLine("Digits : " + DigitCount(a));
System.Console.WriteLine("Min : " + MinDigit(a));
System.Console.WriteLine("Max : " + MaxDigit(a));
System.Console.WriteLine("Sum : " + SumDigits(a));
