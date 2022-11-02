List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
a.Add((a[0] + a[1])/3);
Console.WriteLine(a.Min());