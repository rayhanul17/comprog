int testCase = int.Parse(Console.ReadLine());
while (testCase-- > 0)
{
    int[] numberOf01 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int zeros = numberOf01[0];
    int ones = numberOf01[1];
    int length = zeros + ones;
    string str = string.Empty;

    for (int i = 1; i <= length; i++)
    {
        if(zeros > 0)
        {
            str += 0;
            zeros--;
        }
        if(ones > 0)
        {
            str += 1;
            ones--;
        }
    }
    Console.WriteLine(str);
}
