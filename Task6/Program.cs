int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [x];
for(int j=0;j<x;j++)
{
    arr[j] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
Array.Sort(arr);
for(int j=0;j<x;j++)
{
    cnt=0;
    for(int i=0;i<x;i++)
    {
        if(arr[j]==arr[i])cnt++;
    }
    if(cnt>1)System.Console.Write(arr[j] + " ");
}