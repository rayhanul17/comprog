int contests = int.Parse(Console.ReadLine());
int[] points = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
List<int> list = new List<int>();
list.Add(points[0]);
int count = 0;
for (int i = 1; i < contests; i++)
{    
    if(points[i] > list.Max() || points[i] < list.Min())
        count++;
    list.Add(points[i]);
}
Console.WriteLine(count);