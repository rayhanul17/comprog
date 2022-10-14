int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string input = Console.ReadLine();
    //if (input == "a" || input == "b" || input.Contains("aba") || input.Contains("bab") || input.EndsWith("ab") || input.EndsWith("ba")) ;
    if(input.Split('a').Any(e => e.Length == 1 ) || input.Split('b').Any(e => e.Length == 1))
        Console.WriteLine("NO");
    else
        Console.WriteLine("YES");
}