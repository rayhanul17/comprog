int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    string str = Console.ReadLine();
    int count = 0;
    for (int i = 0; i < len; i += 2)
        if (str[i] != str[i + 1])
            count++;
    Console.WriteLine(count);
}