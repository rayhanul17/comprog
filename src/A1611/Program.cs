int testCase = int.Parse(Console.ReadLine());

for(int t =0; t < testCase; t++)
{
    string n =Console.ReadLine();

    if(int.Parse(n)%2 == 0)
        Console.WriteLine(0);

    else if(int.Parse(n)%2 == 1 && n.Length < 2 )
        Console.WriteLine(-1);

    else
    {
        int index = n.Length;
        for (int i = 0; i < n.Length; i++)
        {
            if (int.Parse(n[i].ToString()) % 2 == 0)
            {
                index = i;
                break;
            }
        }
        if (index == 0)
            Console.WriteLine(1);
        else if (index == n.Length)
            Console.WriteLine(-1);
        else
            Console.WriteLine(2);
    }         
}
