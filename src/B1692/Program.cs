int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int total = int.Parse(Console.ReadLine());
    int count = Console.ReadLine().Split(' ').Distinct().Count();
    Console.WriteLine((total - count) % 2 == 0 ? count : count - 1);   
}
        