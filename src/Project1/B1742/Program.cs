int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    var array = Console.ReadLine().Split().Distinct().ToArray();
    Console.WriteLine(array.Length == n?"Yes":"No");
}