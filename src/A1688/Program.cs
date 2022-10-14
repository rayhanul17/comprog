int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int x = int.Parse(Console.ReadLine());
    int y = 1;
    while (true)
    {
        if (check(x, y))
        {
            Console.WriteLine(y);
            break;
        }
        else if (check(x, y + 1))
        {
            Console.WriteLine(y + 1);
            break;
        }
        else if (check(x, y + 2))
        {
            Console.WriteLine(y + 2);
            break;
        }
        y *= 2;
    }    

    bool check(int x, int y)
    {
        return (x ^ y) > 0 && (x & y) > 0;
    }
}