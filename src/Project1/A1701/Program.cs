int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    int count = (str1 + str2).Count(c => c == '1');
    Console.WriteLine(count == 0 ? 0 : count < 4 ? 1 : 2);
}