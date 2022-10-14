int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] nx = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = nx[0];
    int x = nx[1];
    bool b = true;
    int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(a);
    for(int i = 0; i < n; i++)
        if (a[n+i] - a[i] < x) { b = false; break; }
    Console.WriteLine(b?"YES":"NO");
}
