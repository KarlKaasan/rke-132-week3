int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
    case 0:
        Console.WriteLine("its Sunday")
            break;
        case 1:
        Console.WriteLine("its monday")
            break;
        case 5:
        Console.WriteLine("its friday")
}

Console.WriteLine("Have a nic day")