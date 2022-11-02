using System.Text;
Console.ReadLine();
string input = Console.ReadLine();
StringBuilder sequence = new StringBuilder(new string('0', 10));
int index = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'L')
    {
        index = sequence.ToString().IndexOf('0');
        sequence[index] = '1';
    }
    else if (input[i] == 'R')
    {
        index = sequence.ToString().LastIndexOf('0');
        sequence[index] = '1';
    }
    else
        sequence[input[i] - '0'] = '0';
}
Console.WriteLine(sequence.ToString());