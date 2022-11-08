//Accepted
public class A486
{
    public static void Main(string[] args)
    {
        long n = Convert.ToInt64(Console.ReadLine());
        long sum = n / 2;
        if (n % 2 != 0)
            sum = sum * -1 - 1;
        Console.WriteLine(sum);
    }
}