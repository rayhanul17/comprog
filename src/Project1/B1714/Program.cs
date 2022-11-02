int t = int.Parse(Console.ReadLine());
start:
while (t-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
    HashSet<int> nums = new HashSet<int>();
    for(int i = len-1; i >= 0; i--)
    {
        if (!nums.Add(ints[i])) { Console.WriteLine(len-nums.Count); goto start; }
    }
    Console.WriteLine(0);
}
