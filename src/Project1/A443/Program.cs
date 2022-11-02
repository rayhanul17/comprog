HashSet<char> chars = new HashSet<char>(Console.ReadLine());
Console.WriteLine(chars.Count < 3 ? 0 : chars.Count == 3 ? 1 : chars.Count - 4);