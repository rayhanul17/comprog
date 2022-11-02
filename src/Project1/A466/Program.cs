int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] result = new int[3];
result[0] = array[0] * array[2];
result[1] = (array[0] / array[1] * array[3]) + (array[0] % array[1] * array[2]);
result[2] = (array[0] / array[1] + 1) * array[3];
Console.WriteLine(result.Min());