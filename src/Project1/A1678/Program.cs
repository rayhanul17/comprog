int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine()); 
    var str = Console.ReadLine().Split( ).ToList();
    if (str.Contains("0"))
    {
        int count0 = str.Count(e => e != "0");
        Console.WriteLine(count0);
    }
    else
    {
        int distinctCount = str.Distinct().Count();
        if(distinctCount == str.Count)
            Console.WriteLine(len+1);
        else
            Console.WriteLine(len);
    }
}        