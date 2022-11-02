int n = int.Parse(Console.ReadLine());
int c = 0;
char ch = new char();
for (int i = 0; i < n; i++)
{
    ch = Console.ReadLine()[0];
    c += ch switch
    {
        'T' => 4,
        'C' => 6,
        'O' => 8,
        'D' => 12,
        'I' => 20,
    };
}
Console.WriteLine(c);
/*
Dictionary<string, int> dictionary = new Dictionary<string, int>()
{
    {"Tetrahedron",4},
    {"Cube",6},
    {"Octahedron",8},
    {"Dodecahedron",12},
    {"Icosahedron",20},
};
int n = int.Parse(Console.ReadLine());
int res = 0;
for (int i = 0; i < n; i++)
    res += dictionary[Console.ReadLine()];
Console.WriteLine(res);
*/