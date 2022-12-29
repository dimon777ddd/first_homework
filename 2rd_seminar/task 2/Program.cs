Console.Write("Enter number: ");

int RandomNumber = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(RandomNumber);

if (Number.Length > 2)
{
  Console.WriteLine("Third digit " + Number[2]);
}
else 
{
  Console.WriteLine("Number has not third digit");
}