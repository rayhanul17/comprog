using System;

public class A63
{
    public static void Main(string[] args)
    {
        int totalMembers = int.Parse(Console.ReadLine());
        string[] memberNames = new string[totalMembers];
        string[] names = new string[totalMembers];
        string[] titles = new string[totalMembers];

        for (int i = 0; i < totalMembers; i++)
        {
            memberNames[i] = Console.ReadLine();
            names[i] = memberNames[i].Split(" ")[0];
            titles[i] = memberNames[i].Split(" ")[1];

        }

        string[] tags = new string[] { "rat", "child", "woman", "man", "captain" };


        for (int i = 0; i < tags.Length; i++)
        {
            for (int j = 0; j < totalMembers; j++)
            {
                if (i == 1)
                {
                    if (titles[j] == tags[i] || titles[j] == tags[i + 1])
                        Console.WriteLine(names[j]);

                }
                else if (i == 2)
                    continue;
                else
                {
                    if (titles[j] == tags[i])
                        Console.WriteLine(names[j]);
                }

            }
        }
    }
}