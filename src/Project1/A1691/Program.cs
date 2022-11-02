int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int even = numbers.Count(c => c % 2 == 0);
    int odd = len - even;

    Console.WriteLine(even < odd ? even : odd);
}