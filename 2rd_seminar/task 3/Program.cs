
Console.WriteLine("Enter weekday number: ");

int weekdayNum = Convert.ToInt32(Console.ReadLine());

if (weekdayNum < 1 || weekdayNum > 7)
{
    Console.WriteLine("Weekday number can't be < 1 and > 7");
}

else if (weekdayNum == 6 || weekdayNum == 7)
{
  Console.WriteLine("Holiday");
}
 else
{
  Console.WriteLine("Work day");
}
        
    