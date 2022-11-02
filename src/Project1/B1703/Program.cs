int test = int.Parse(Console.ReadLine());

while (test-- > 0)
{
    int l = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();
    HashSet<char> set = new HashSet<char>(s);
    Console.WriteLine(set.Count + l);    
}