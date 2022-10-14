int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    int[] piles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if (len % 2 == 1) Console.WriteLine("Mike");
    else
    {
        int index = Array.IndexOf(piles, piles.Min());
        if (index % 2 == 0) Console.WriteLine("Joe");
        else Console.WriteLine("Mike");
    }
}