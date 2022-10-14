int testCase = int.Parse(Console.ReadLine());

for (int t = 0; t < testCase; t++)
{
    string[] numbers = Console.ReadLine().Split(' ');
    int n1 = int.Parse(numbers[0]);
    int n2 = int.Parse(numbers[1]);

    int min = n1>n2 ? n2 : n1;
    int result = (n1+n2)/4 > min? min : (n1 + n2) / 4;

    Console.WriteLine(result);
}

