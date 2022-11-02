int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Sort(input);
Console.WriteLine($"{input[0]} {(input[1] - input[0]) / 2}");