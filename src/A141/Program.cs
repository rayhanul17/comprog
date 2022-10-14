string names = Console.ReadLine() + Console.ReadLine();
string pile = Console.ReadLine();
bool condition = true;
List<char> charList = names.ToHashSet().ToList();
for (int i = 0; i < charList.Count; i++)
    if (!(names.Count(e => e == charList[i]) == pile.Count(e => e == charList[i]))) { condition = false; break; }
Console.WriteLine(names.Length == pile.Length && condition ? "YES" : "NO");