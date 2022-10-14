int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var z = Array.IndexOf(a, a.Max()) + (n - 1 - Array.LastIndexOf(a, a.Min()));
Console.WriteLine(z >= n ? z - 1 : z);