int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int n1 = 0;
    string s = string.Empty;
    for (int i = 9; i > 0; i--)
    {
        n1 += i;
        if (n1 < n || n == n1)
        {
            s = i + s;
        }
        else
            n1 -= i;
    }
    Console.WriteLine(s);
}