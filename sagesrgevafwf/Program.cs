char letter;
Console.WriteLine("Hinne?");
letter = Convert.ToChar(Console.ReadLine().ToLower());

switch (letter)
{ 
    case 'a':
        Console.WriteLine("Suurepärane!");
        break;
    case 'b':
        Console.WriteLine("Väga hea!");
        break;
    case 'c':
        Console.WriteLine("Hea!");
        break;
    case 'd':
        Console.WriteLine("Halb");
        break;
    case 'e':
        Console.WriteLine("Kasin");
        break;
    case 'f':
        Console.WriteLine("puudulik");
        break;
    default:
        Console.WriteLine("Vale väärtus");
        break;
}
