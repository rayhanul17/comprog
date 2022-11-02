int t = int.Parse(Console.ReadLine());
string[] ans = new string[t];

Dictionary<int, char> dictionary = new Dictionary<int, char>();
int cc = 97;
for (int _ = 1; _ < 27; _++)
{
    dictionary.Add(_, (char)cc++);
}

for (int k = 0; k < t; k++)
{
    int n = int.Parse(Console.ReadLine());
    string input = Console.ReadLine();
    string[] code = new string[n];
    n--;
    int i = 0;
    for (int _ = n; _ >= 0; _--)
        code[_] = input[i++].ToString();

    string str = string.Empty;

    i = 0;
    int num = 0;
    while (n >= i)
    {
        if (code[i] == "0")
        {
            num = int.Parse(code[i + 2] + code[i + 1]);
            str = dictionary[num] + str;
            i += 3;
        }
        else
        {
            num = int.Parse(code[i++]);
            str = dictionary[num] + str;
        }
    }
    ans[k] = str;
}
Console.WriteLine(string.Join('\n', ans));