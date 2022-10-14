Console.ReadLine();
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
HashSet<int> set = new HashSet<int>();
for(int i = 0; i < numbers.Length; i++)
{
    while (numbers[i] % 2 == 0) numbers[i]/= 2;
    while (numbers[i] % 3 == 0) numbers[i]/= 3;
    set.Add(numbers[i]);
}
Console.WriteLine(set.Count>1?"No":"Yes");
