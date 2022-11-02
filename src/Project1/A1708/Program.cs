int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    Console.ReadLine();
    int[] a1 = Console.ReadLine().Split().Select(int.Parse).ToArray();    
    bool b = true;
    for (int i = 1; i < a1.Length; i++) 
        if (a1[i] % a1[0] != 0) { b = false; break; }
    Console.WriteLine(b?"YES":"NO");    
}