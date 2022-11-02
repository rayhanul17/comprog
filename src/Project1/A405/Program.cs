Console.ReadLine();
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Sort(a);
Console.WriteLine(string.Join(" ", a));
