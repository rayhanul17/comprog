int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dictionary = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    if (dictionary.ContainsKey(name))
    {
        Console.WriteLine(name + dictionary[name]);
        ++dictionary[name];
    }
    else
    {
        Console.WriteLine("OK");
        dictionary[name] = 1;
    }
}
