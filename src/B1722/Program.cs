int t = int.Parse(Console.ReadLine());
string[] result = new string[t];
for (int i = 0; i < t; i++)
{
    Console.ReadLine();
    string s1 = Console.ReadLine().Replace('G', 'B');
    string s2 = Console.ReadLine().Replace('G', 'B');
    result[i] = s1 == s2 ? "YES" : "NO";
}
Console.WriteLine(string.Join("\n", result));