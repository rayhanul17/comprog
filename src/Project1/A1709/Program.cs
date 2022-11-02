int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int k = int.Parse(Console.ReadLine());
    int[] a = ("0 " + Console.ReadLine()).Split().Select(int.Parse).ToArray();
    Console.WriteLine(a[a[k]] == 0 ? "NO" : "YES");
}
