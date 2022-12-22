//second task
int i = 0;
int max_number = 0;
while (i < 3)
{
    Console.Write($"Enter {i+1} number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > max_number)
    {
        max_number = number;
    }
       i++; 
}
Console.WriteLine($"Max number = {max_number}");
