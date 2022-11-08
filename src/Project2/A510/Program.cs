using System;

class A510
{
    public static void Main(string[] args)
    {
        string rc = Console.ReadLine();
        int count = 0;

        string str1 = string.Empty;
        string str2 = "#";
        string str3 = "#";

        int row = int.Parse(rc.Split(' ')[0]);
        int col = int.Parse(rc.Split(' ')[1]);

        for (int i = 0; i < col; i++)
            str1 = str1 + "#";
        for(int i = 1;i < col; i++)
            str2 = "." + str2;
        for(int i = 1; i < col ; i++)
            str3 = str3 + ".";

        string[] lines = {str1,str2,str1,str3 };

        while(count<row)
        {
            for(int i=0; i<4; i++)
            {
                Console.WriteLine(lines[i]);
                count++;
                if(count == row)
                    break;
            }
            
        }      
        
    }
}