int len = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (len == 1)
    Console.WriteLine(1);
else
{
    int res = 0;
    int c = 1;
    for (int i = 0; i < len - 1; i++)
    {
        if (a[i] <= a[i + 1])
            c++;
        else
        {
            res = Math.Max(res, c);
            c = 1;
        }
        if (i == len - 2)
            Console.WriteLine(Math.Max(res, c));
    }
}