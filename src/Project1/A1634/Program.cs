int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int k = int.Parse(Console.ReadLine().Split()[1]);
    Console.ReadLine();
    Console.WriteLine(k < 2 ? 1 : 2);
    
}