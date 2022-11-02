int testCase = int.Parse(Console.ReadLine());

for (int t = 0; t < testCase; t++)
{
    int length = int.Parse(Console.ReadLine());
    string str = Console.ReadLine();

    int mid = length / 2;
    int count = 1;

    for(int i = mid+1; i < length; i++)
    {
        if (str[mid] == str[i])
            count++;
        else
            break;
    }

    for(int i = mid-1; i >= 0; i--)
    {
        if (str[mid] == str[i])
            count++;
        else
            break;
    }

    Console.WriteLine(count);
}