int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (array.Min() * 2 + 1 < array.Max()) Console.WriteLine(array.Min());
    else Console.WriteLine((array[0] + array[1]) / 3);
    //Console.WriteLine(Math.Min(array.Min(), (array[0] + array[1]) /3));
}