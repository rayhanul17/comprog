//B1843
long t = long.Parse(Console.ReadLine());

while(t-- > 0)
{
    Console.ReadLine();
    long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
    long sum = 0;
    long c = 0, b = 0;
    for(long i = 0; i < input.Length; i++)
    {
        sum += Math.Abs(input[i]);
        if (input[i] <= 0)
            b += input[i];
        else
        {
            c += b < 0 ? 1 : 0;            
            b = 0;
        }
        
    }
    c += b < 0 ? 1 : 0;
    Console.WriteLine($"{sum} {c}");
}