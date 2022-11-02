int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string pattern = Console.ReadLine();
    string word = Console.ReadLine();
    int sum = 0;
    for(int i = 1; i < word.Length; i++)
        sum += Math.Abs(pattern.IndexOf(word[i-1]) - pattern.IndexOf(word[i]));
    Console.WriteLine(sum);
}