int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    TimeOnly t1 = new TimeOnly(a[1], a[2]);
    TimeSpan ts = new TimeSpan();
    SortedSet<string> s = new SortedSet<string>();
    for (int i = 0; i < a[0]; i++)
    {
        int[] al = Console.ReadLine().Split().Select(int.Parse).ToArray();
        ts = new TimeOnly(al[0], al[1]) - t1;
        s.Add(ts.ToString());
    }
    string str = string.Join(" ", s.First().ToString().Split(":").Select(int.Parse).ToArray());
    str = str.Split()[0] + " " + str.Split()[1];
    Console.WriteLine(str);
}