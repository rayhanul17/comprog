int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int sum = numbers.Sum();
    int subTotal = 0;
    for(int i = 0; i < len; i++)
    {
        subTotal = sum - numbers[i];
        if ((float)subTotal / (len - 1) == numbers[i])
        {
            Console.WriteLine("YES");
            break;
        }
        if (i == len - 1) Console.WriteLine("NO");
    }
}