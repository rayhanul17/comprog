int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    string s = Console.ReadLine();
    Dictionary<int, char> map = new Dictionary<int, char>();
    bool flag = true;

    for (int i = 0; i < n; i++)
    {
        if (map.ContainsKey(a[i]))
        {
            if (map[a[i]] != s[i])
            {
                flag = false;
                break;
            }
        }
        else
            map.Add(a[i], s[i]);
    }
    Console.WriteLine(flag ? "YES" : "NO");
}