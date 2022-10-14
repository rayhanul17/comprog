int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    Console.ReadLine();
    int[] array = Console.ReadLine().Split( ).Select(int.Parse).ToArray();
    SortedSet<int> set = new SortedSet<int>();
    for(int i = 0; i < array.Length; i++)
    {
        if (set.Contains(array[i]))
            array[i] = -array[i];
        set.Add(array[i]);
    }
    Console.WriteLine(set.Count());
}
