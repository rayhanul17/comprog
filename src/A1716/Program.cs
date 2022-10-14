int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int num = int.Parse(Console.ReadLine());
    if (num == 1) { Console.WriteLine(2); continue; }
    Console.WriteLine(num % 3 == 0 ? num / 3 : num / 3 + 1);
}