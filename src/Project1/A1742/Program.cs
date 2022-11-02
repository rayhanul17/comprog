int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(array);
    Console.WriteLine(array[0] + array[1] == array[2] ? "Yes" : "No");
}