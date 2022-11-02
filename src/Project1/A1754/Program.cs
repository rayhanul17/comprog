int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int count = 0;
    Console.ReadLine();
    string msgs = Console.ReadLine();
    foreach (char c in msgs)
    {
        if (c == 'Q')
            count++;
        else if (count > 0) 
            count--;
    }
    Console.WriteLine(count > 0 ? "No" : "Yes");
}