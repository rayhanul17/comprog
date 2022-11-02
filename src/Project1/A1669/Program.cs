int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Division " + number switch
    {
        <= 1399 => 4,
        >= 1400 and <= 1599 => 3,
        >= 1600 and <= 1899 => 2,
        _ => 1
    });
}