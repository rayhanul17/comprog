int test = int.Parse(Console.ReadLine());
while(test-- > 0)
{
    string s = Console.ReadLine();
    int ab = 0;
    int ba = 0;
    for (int i = 0; i < s.Length - 1; i++)
    {
        if (s[i] == 'a' && s[i + 1] == 'b') ab++;
        if (s[i] == 'b' && s[i + 1] == 'a') ba++;
    }
    Console.WriteLine(ab==ba?s:ab>ba?'b'+s.Substring(1):'a'+s.Substring(1));
}
