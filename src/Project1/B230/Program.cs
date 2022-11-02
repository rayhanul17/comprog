Console.ReadLine();
Console.WriteLine(string.Join('\n', Console.ReadLine().Split(" ").Select(long.Parse)
    .Select(x => (Math.Floor(Math.Sqrt(x)) == Math.Ceiling(Math.Sqrt(x)) && IsPrime((long)Math.Sqrt(x))) ? "YES" : "NO")));

bool IsPrime(long n)
{
    if (n < 2) return false;
    for (long i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
    return true;
}
