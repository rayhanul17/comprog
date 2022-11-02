int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{    
    string[] s1 = new string[8];
    Console.ReadLine();
    char ans = 'B';
    for (int i = 0; i < 8; i++)
        s1[i] = Console.ReadLine();
    foreach(string c in s1)
    {
        if(c == "RRRRRRRR")
        {
            ans = 'R';
            break;
        }       
    }
    Console.WriteLine(ans);
}