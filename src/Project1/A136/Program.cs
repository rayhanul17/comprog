int n = int.Parse(Console.ReadLine());
int[] result = new int[n];
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < n; i++)
    result[input[i] - 1] = i + 1;
Console.WriteLine(string.Join(" ", result));