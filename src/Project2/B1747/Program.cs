int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int a = (n + 1) / 2;
    Console.WriteLine(a);
    n *= 3;
    for (int i = 0; i < a; i++)
        Console.WriteLine($"{3 * i + 2} {n - i * 3}");
}