int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();   
    Console.WriteLine(GetElements(array));
}
string GetElements(int[] array)
{
    int def = array[array.Length - 1] - array[0];
    string str = array[0].ToString() + " ";
    for (int i = 1; i < array.Length - 1; i++)
        for (int j = i; j < array.Length - 1; j++)
            if (array[i] + array[j + 1] == def)
                return str += array[j + 1].ToString() + " " + array[i].ToString();
    return null;
}
   