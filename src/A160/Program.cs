int l = int.Parse(Console.ReadLine());
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Sort(numbers);
Array.Reverse(numbers);
int sum = 0;
int subTotal = numbers.Sum()/2;
for (int i = 0; i < l; i++)
{
    sum += numbers[i];
    if (sum > subTotal) { Console.WriteLine(++i); break; }
    else if (sum == subTotal) { Console.WriteLine(i + 2); break; }
}