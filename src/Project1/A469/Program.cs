int n = int.Parse(Console.ReadLine());
HashSet<string> set = new HashSet<string>();
var a = Console.ReadLine().Split().Skip(1).ToList();
var b = Console.ReadLine().Split().Skip(1).ToList();
a.ForEach(x => set.Add(x));
b.ForEach(x => set.Add(x));
Console.WriteLine(set.Count == n ? "I become the guy." : "Oh, my keyboard!");