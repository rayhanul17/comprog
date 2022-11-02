int t = int.Parse(Console.ReadLine());
int[] res = new int[t];
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int xmax, xmin, ymax, ymin;
    xmax = ymax = xmin = ymin = 0;
    for (var i = 0; i < n; i++)
    {
        int[] axis = GetAxis();
        xmax = Math.Max(xmax, axis[0]);
        xmin = Math.Min(xmin, axis[0]);
        ymax = Math.Max(ymax, axis[1]);
        ymin = Math.Min(ymin, axis[1]);
    }
    res[t] = (xmax - xmin + ymax - ymin) * 2;
}
string str = string.Join("\n", res.Reverse());
Console.WriteLine(str);
int[] GetAxis() => Console.ReadLine().Split().Select(int.Parse).ToArray();