class A791
{
    public static void Main(string[] args)
    {
        string lb = Console.ReadLine();
        string[] weigts = lb.Split(' ');

        int yrs = 0;

        int l = int.Parse(weigts[0]);
        int b = int.Parse(weigts[1]);

        while (!(l > b))
        {
            l *= 3;
            b *= 2;
            yrs++;
        }
        Console.WriteLine(yrs);
    }

}
