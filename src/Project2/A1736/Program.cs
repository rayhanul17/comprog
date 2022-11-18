int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    string a = Console.ReadLine().Replace(" ", "");
    string b = Console.ReadLine().Replace(" ", "");
    int count = Math.Abs(a.Replace(" ", "").Count(x => x == '1') - b.Replace(" ", "").Count(x => x == '1'));
    int c = 0;
    for (int i = 0; i < n; i++)
    {
        if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
            c++;
    }
    Console.WriteLine(c == count ? count : ++count);
}
