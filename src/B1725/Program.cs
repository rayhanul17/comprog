int d = int.Parse(Console.ReadLine().Split()[1]);
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Sort(array);
int l = 0;
int r = array.Length - 1;
int ans = 0;
while (l <= r)
{
    l += d / array[r];
    if (l <= r)
        ans += 1;
    r -= 1;
}
Console.Write(ans);