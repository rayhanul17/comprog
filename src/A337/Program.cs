int student = int.Parse(Console.ReadLine().Split(' ')[0]);

int[] puzzles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Array.Sort(puzzles);
int index = 0;
int min = puzzles[student-1] - puzzles[0];
for(int i = 1; i <= puzzles.Length-student; i++)
{
    if (puzzles[i + student - 1] - puzzles[i] <= min)
    {
        min = puzzles[i + student - 1] - puzzles[i];
        index = i;
    }
}
Console.WriteLine(puzzles[index+student-1] - puzzles[index]);