Console.Write($"Enter how many numbers you want to check:");
int numbers = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i < numbers)
{
    Console.Write($"Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine($"Number {number} is even");
    }
    else
    {
        Console.WriteLine($"Number {number} is odd");
    }
        i++;
}
