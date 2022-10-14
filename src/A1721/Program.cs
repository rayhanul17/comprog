int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string s = Console.ReadLine() + Console.ReadLine();
    HashSet<char> set = new HashSet<char>(s);
    Console.WriteLine(set.Count - 1);
}