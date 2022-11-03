using System;
public class A208
{
    public static void Main(string[] args)
    {
        string remixSong = Console.ReadLine();
        string song = remixSong.Replace("WUB", " ").Trim();
        string realSong = song[0].ToString();

        for(int i = 1; i < song.Length; i++)
        {
            if (song[i-1] == ' ' && song[i] == ' ')
                continue;
            else
                realSong += song[i];
        }

        Console.WriteLine(realSong);
    }
}