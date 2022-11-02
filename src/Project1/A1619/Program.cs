int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    string str = Console.ReadLine();
    int len = str.Length / 2 ;
    Console.WriteLine((str.Length % 2 == 1) ? "NO" : (str[..len] == str[len..]) ? "YES" : "NO");
}