int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] a1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] a2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

    string s1 = a1[0] + "";
    string s2 = a2[0] + "";
    int l1 = s1.Length;
    int l2 = s2.Length;

    if (l1 + a1[1] > l2 + a2[1])
        Console.WriteLine(">");
    else if (l1 + a1[1] < l2 + a2[1])
        Console.WriteLine("<");
    else
    {
        int n = Math.Abs(l1 - l2);
        if (l1 < l2)
            s1 += new string('0', n);
        else
            s2 += new string('0', n);
        int ans = string.Compare(s1, s2);
        Console.WriteLine(ans == 1 ? ">" : ans == 0 ? "=" : "<");
    }
}