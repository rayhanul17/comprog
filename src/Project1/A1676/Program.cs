int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] a = Console.ReadLine().Select(e => Convert.ToInt32(e)).ToArray();
    if (a[0..3].Sum() *2 == a.Sum()) Console.WriteLine("YES");
    else Console.WriteLine("NO");    
}
