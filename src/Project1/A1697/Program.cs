int test = int.Parse(Console.ReadLine());
while(test-- > 0)
{
    int energy = int.Parse(Console.ReadLine().Split(' ')[1]);
    int totalEnergy = Console.ReadLine().Split(' ').Select(int.Parse).Sum();
    Console.WriteLine((totalEnergy - energy) <= 0 ? 0 : totalEnergy - energy);
}