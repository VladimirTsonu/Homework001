Console.Write("Enter first number: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter thrid number: ");
int thridNumb = Convert.ToInt32(Console.ReadLine());
int maxNumb = firstNumb;

if (secondNumb > maxNumb)
{
    maxNumb = secondNumb;
}
if (thridNumb > maxNumb)
{
    maxNumb = thridNumb;
}

Console.WriteLine("maximum number is: " + maxNumb );

