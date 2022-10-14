int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string str = Console.ReadLine();
    HashSet<char> set = new HashSet<char>();
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        set.Add(str[i]);
        if (set.Count == 4)
        {
            count++;
            set.Clear();
            set.Add(str[i]);
        }
        if (i == str.Length - 1 && set.Count > 0)
            count++;
    }
    Console.WriteLine(count);
}