int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    Console.ReadLine();
    long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
    long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
    Console.WriteLine((a.Sum() + b.Sum()) - b.Max());
}