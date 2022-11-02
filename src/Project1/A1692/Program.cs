int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] distances = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int count = distances.Where(x => x > distances[0]).Count();
    Console.WriteLine(count);
}