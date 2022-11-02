int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{   
    string str = Console.ReadLine();
    //if(str.IndexOf('r')<str.IndexOf('R') && str.IndexOf('g') < str.IndexOf('G') && str.IndexOf('b') < str.IndexOf('B'))
    string str2 = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if(i == str.Length - 1)
            Console.WriteLine("YES"); 
        else if (char.IsLower(str[i]))        
            str2 += str[i];        
        else
        {
            if (!str2.Contains(char.ToLower(str[i])))
            {
                Console.WriteLine("NO");
                break;
            }
        }
                    
    }
}
