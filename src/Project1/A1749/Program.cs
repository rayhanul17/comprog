int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int i = 0; i < nm[1]; i++)
        Console.ReadLine();
    Console.WriteLine(nm[1] < nm[0] ? "YES" : "NO");
}