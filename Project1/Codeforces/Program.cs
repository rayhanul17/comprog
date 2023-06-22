//B1843
int t = int.Parse(Console.ReadLine());

while(t-- > 0)
{
    Console.ReadLine();
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    long sum = Math.Abs(input[0]);
    int c = 0;
    for(int i = 1; i < input.Length; i++)
    {
        sum += Math.Abs(input[i]);
        if ((input[i - 1] < 0 && input[i] > 0) || (input[i - 1] > 0 && input[i] < 0))
            c++;
    }
    Console.WriteLine($"{sum} {c}");
}