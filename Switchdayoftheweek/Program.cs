﻿int Weekday = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0-6

switch(Weekday) //väärtus mida kontrollitakse
{
    case 0: //case0 == If(WeekDay == 0)
        Console.WriteLine("its Sunday!");
        break;
    case 1: Console.WriteLine("Its Monday");
        break;
    case 2: Console.WriteLine("Its Tuesday");
        break;
    case 3: Console.WriteLine("Its Wednesday");
        break;
    case 4: Console.WriteLine("Its Thursday");
        break;
    case 5: Console.WriteLine("Its Friday");
        break;
    case 6: Console.WriteLine("Its Saturday");
            break;
    default:
        Console.WriteLine("Oops your calendar must be broken");
        break;
}

Console.WriteLine("Have a nice day!");