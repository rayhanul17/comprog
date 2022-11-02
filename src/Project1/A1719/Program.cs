int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine((input[0] + input[1] - 1) % 2 == 0 ? "Burenka" : "Tonya");
}