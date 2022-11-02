int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(n - Math.Pow(10, n.ToString().Length - 1));
}