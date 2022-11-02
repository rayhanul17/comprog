int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    Console.ReadLine();
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine(array.Max()-array.Min());
}

