int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (array[0] % array[1] == 0) { Console.WriteLine(0); }
    else if (array[0] <= array[1]) { Console.WriteLine(array[1] - array[0]); }
    else { Console.WriteLine(array[1] - array[0] % array[1]); }
}