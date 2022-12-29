Console.Write("Enter threedigit number: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("Second digit of this number is "+stringNumber[1]);
