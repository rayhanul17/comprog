int t = int.Parse(Console.ReadLine());
int[] result = new int[t];
for (int i = 0; i < t; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    result[i] = ((input[2] - input[4] > 1 && input[3] + input[4] < input[1]) || (input[2] + input[4] < input[0] && input[3] - input[4] > 1)) ? (input[0] + input[1] - 2) : -1;
}
Console.WriteLine(string.Join('\n', result));