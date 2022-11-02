int l = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] array = new int[l];
array[0] = a[0];

for (int i = 1; i < l; i++)
    array[i] = array[i - 1] + a[i];

int q = int.Parse(Console.ReadLine());
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] ans = new int[q];

for (int i = 0; i < q; i++)
{
    ans[i] = Find(array, numbers[i]);
}
Console.WriteLine(string.Join("\n", ans));

int Find(int[] array, int value)
{
    int l = 0;
    int r = array.Length - 1;
    int m;
    while (l < r)
    {
        m = l + (r - l) / 2;
        if (array[m] < value)
            l = m + 1;
        else
            r = m;
    }
    return l + 1;
}