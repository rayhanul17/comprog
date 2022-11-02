int testCase = int.Parse(Console.ReadLine());

while (testCase-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    if(n%2 == 0)
        Console.WriteLine($"{n/2} {n/2} 0");
    else
        Console.WriteLine(-1);
}

