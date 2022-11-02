int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{    
    int.Parse(Console.ReadLine());
    string input = Console.ReadLine();
    if (input.All(e => e == '0' || e == ' '))
        Console.WriteLine(0);
    else
    {
        string[] inputArray = input.Split(' ');
        string[] otherChar = inputArray.Where(e => e != "0").ToArray();
        string newInput = string.Join("", inputArray);
        string newCharArray = string.Join("", otherChar);     
        if (newInput.Contains(newCharArray))
            Console.WriteLine(1);
        else
            Console.WriteLine(2);
    }    
}