int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string[] arrays = Console.ReadLine().Split('0').Where(s => s.Length != 0).ToArray();
    Array.Sort(arrays);
    Array.Reverse(arrays);    
    int point = 0;
    for (int i = 0; i < arrays.Length; i += 2)
        point += arrays[i].Length;
    Console.WriteLine(point);
}