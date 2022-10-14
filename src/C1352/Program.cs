int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = a[0];
    int k = a[1];
    Console.WriteLine(FindValue(n, k));
    static int FindValue(int n, int k)
    {
        int l = 1;
        int r = 2000000000;
        int m, v;
        while (l < r)
        {
            m = l + (r - l) / 2;
            v = m - (m / n);
            if (v < k)
                l = m + 1;
            else
                r = m;
        }
        return l;
    }
}