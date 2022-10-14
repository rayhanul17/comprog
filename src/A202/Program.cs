string str = Console.ReadLine();
Console.WriteLine(new string(str.Max(), str.Count(e => e == str.Max())));