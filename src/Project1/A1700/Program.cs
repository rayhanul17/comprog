int testCase = int.Parse(Console.ReadLine());

for (int t = 0; t < testCase; t++)
{
    string[] numbers = Console.ReadLine().Split(' ');
    int n = int.Parse(numbers[0])-1;
    int m = int.Parse(numbers[1]);

    decimal sum1 = m*(m+1)/2;
    decimal sum2 = (decimal)n / 2 * (2 * m*2 + (n - 1) * m);

    Console.WriteLine((long)(sum1+sum2));
}
