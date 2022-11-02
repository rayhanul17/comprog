int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    Solve(n);
}
void Solve(int n)
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    var set = new HashSet<string>[3];
    int[] ans = new int[3];
    for (int i = 0; i < 3; i++)
        set[i] = new HashSet<string>();

    string[] input = new string[n];
    for (int i = 0; i < 3; i++)
    {
        input = Console.ReadLine().Split();
        for (int j = 0; j < n; j++)
        {

            if (dictionary.ContainsKey(input[j]))
                dictionary[input[j]]++;
            else
                dictionary[input[j]] = 1;
            set[i].Add(input[j]);
        }
    }
    for (int i = 0; i < 3; i++)
    {
        foreach (var item in set[i])
        {
            if (dictionary[item] == 1)
                ans[i] += 3;
            else if (dictionary[item] == 2)
                ans[i] += 1;
        }
    }
    Console.WriteLine(string.Join(" ", ans));
}