int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    string[] SubStrs = Console.ReadLine().Split();
    string str = SubStrs[0];
    for(int i = 1; i < SubStrs.Length; i++)
    {
        if (SubStrs[i - 1][1] != SubStrs[i][0])
            str += SubStrs[i];
        else
            str += SubStrs[i][1];
    }
    Console.WriteLine(str.Length < len ? str + 'a' : str);
}
