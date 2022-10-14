int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int d = a[0] - a[3];
    if (d > 0)
        d = 0;
    int c = a[1] - a[4];
    if(c > 0)
        c = 0;
    if (d + c + a[2] < 0)
        Console.WriteLine("NO");
    else
        Console.WriteLine("YES");
    
}