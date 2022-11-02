int testCase = int.Parse(Console.ReadLine());
while (testCase-- > 0)
{
    Console.ReadLine();
    string input = Console.ReadLine();
    //var input = string.Concat(Console.ReadLine().OrderBy(c => c));
    var distinctStr = string.Concat(input.Distinct());
    for(int i = 0; i < distinctStr.Length; i++)
    {
        char c = distinctStr[i];
        int count = input.Count(e => e == c);
        string manyChar = new string(c, count);
        if (!input.Contains(manyChar))
        {
            Console.WriteLine("NO");
            break;
        }
        if(i == distinctStr.Length - 1)
            Console.WriteLine("YES");
    }    
}
