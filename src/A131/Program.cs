string str = Console.ReadLine();
if (str == str.ToUpper())
    Console.WriteLine(str.ToLower());
else if (str[1..].ToUpper() == str[1..])
    Console.WriteLine(char.ToUpper(str[0]) + str[1..].ToLower());
else
    Console.WriteLine(str);