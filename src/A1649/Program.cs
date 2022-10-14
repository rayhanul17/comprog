int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    Console.ReadLine();
    string str = Console.ReadLine().Replace(" ","");
    int firstIndex = str.IndexOf('0');
    if(firstIndex == -1)
    {
        Console.WriteLine(0);
        continue;
    }
    int lastIndex = str.LastIndexOf('0');
    Console.WriteLine(lastIndex-firstIndex+2);
}