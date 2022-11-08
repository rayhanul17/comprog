using System;
public class A230
{
    public static void Main(string[] args)
    {
        string[] sn = Console.ReadLine().Split(' ');

        int s = int.Parse(sn[0]);
        int n = int.Parse(sn[1]);

        string[] dsBp = new string[n];
        int[] dragonStrength = new int[n];
        int[] bonusPower = new int[n];

        int dragonTemp, bonusTemp;
        int count = 0;

        for(int i = 0; i < n; i++)
        {
            dsBp[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            dragonStrength[i] = int.Parse(dsBp[i].Split(' ')[0]);
            bonusPower[i] = int.Parse(dsBp[i].Split(' ')[1]);
        }

        

        for(int i = 0;i < n; i++)
        {
            for(int j = 0;j < n-1; j++)
            {
                if(dragonStrength[j] > dragonStrength[j + 1])
                {
                    dragonTemp = dragonStrength[j];
                    dragonStrength[j] = dragonStrength[j + 1];
                    dragonStrength[j + 1] = dragonTemp;

                    bonusTemp = bonusPower[j];
                    bonusPower[j] = bonusPower[j + 1];
                    bonusPower[j + 1] = bonusTemp;
                }
            }
        }

        
        for(int i = 0; i < n; i++)
        {
            if (s > dragonStrength[i])
            {
                s = s + bonusPower[i];
                count++;
            }
            else
                break;
        }

        Console.WriteLine(count == n ? "YES" : "NO");
    }
}
