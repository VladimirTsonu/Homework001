Console.Write("Enter first number: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());
if (firstNumb > secondNumb)
{
    Console.WriteLine("maximum number is: " + firstNumb );
}
else
{
    Console.WriteLine("maximum number is: " + secondNumb );
}