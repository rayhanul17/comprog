int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string input = Console.ReadLine();
    Console.WriteLine(input.Length == 2 ? input[1] : input.Min());
}
