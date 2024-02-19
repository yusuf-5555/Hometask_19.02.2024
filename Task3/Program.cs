void NegNum(int a)
{
    int cnt=0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]<0)cnt++;
    }
    System.Console.WriteLine("Negative : " + cnt);
}
void PosNum(int a)
{
    int cnt=0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]>0)cnt++;
    }
    System.Console.WriteLine("Positive : " + cnt);
}
void Zeros(int a)
{
    int cnt=0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]==0)cnt++;
    }
    System.Console.WriteLine("Zeros : " + cnt);
}
void EvenNum(int a)
{
    int cnt=0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]%2==0)cnt++;
    }
    System.Console.WriteLine("Even : " + cnt);
}
void OddNum(int a)
{
    int cnt=0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]%2!=0)cnt++;
    }
    System.Console.WriteLine("Odd : " + cnt);
}
void MaxNum(int a)
{
    int cnt=99999;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]<cnt)cnt=arr[i];
    }
    System.Console.WriteLine("Max : " + cnt);
}
void MinNum(int a)
{
    int cnt=-99999;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        if(arr[i]>cnt)cnt=arr[i];
    }
    System.Console.WriteLine("Min : " + cnt);
}
void SumNum(int a)
{
    int cnt = 0;
    int[] arr = new int[a];
    for(int i=0;i<a;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<a;i++)
    {
        cnt = cnt+arr[i];
    }
    System.Console.WriteLine("Sum : " + cnt);
}
int a = Convert.ToInt32(Console.ReadLine());
NegNum(a);
PosNum(a);
Zeros(a);
EvenNum(a);
OddNum(a);
MaxNum(a);
MinNum(a);
SumNum(a);