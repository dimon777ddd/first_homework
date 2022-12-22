//first task
Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("The first number is equal to the second number");
}

else if (number1 > number2)
{
    Console.WriteLine("First number is bigger then second number");
}

else
{
    Console.WriteLine("Second number is bigger then first number");
}


