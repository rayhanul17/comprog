int[] productQuery = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

Array.Sort(prices);

long[] myArray = new long[productQuery[0] + 1];
myArray[0] = 0;
for (int i = 1; i <= productQuery[0]; i++)
    myArray[i] = myArray[i - 1] + prices[i - 1];

while (productQuery[1]-- > 0)
{
    int[] buyGet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int buy = buyGet[0];
    int get = buyGet[1];
    long ans = myArray[productQuery[0] - buy + get] - myArray[productQuery[0] - buy];
    Console.WriteLine(ans);
}
