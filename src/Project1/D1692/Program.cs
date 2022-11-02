int testCase = int.Parse(Console.ReadLine());
while(testCase-- > 0)
{    
    string[] input = Console.ReadLine().Split(' ');
    int count = 0;
    int hour = int.Parse(input[0].Split(':')[0]);
    int minute = int.Parse(input[0].Split(':')[1]);
    int addingMinute = int.Parse(input[1]);
    TimeOnly timeOnly = new TimeOnly(hour,minute);

    while (true)
    {
        timeOnly = timeOnly.AddMinutes(addingMinute);
        string time = timeOnly.ToString("HH:mm");
        if (time[0].ToString() + time[1] == time[4].ToString() + time[3])
            count++;
        if (timeOnly == new TimeOnly(hour, minute))
            break;        
    }
    Console.WriteLine(count);   
}