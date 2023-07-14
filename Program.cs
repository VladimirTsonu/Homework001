// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int MiddleDigit (int number)
{
    int removeHun = number % 100;
    int dec = removeHun / 10;
    return dec;
}

Console.WriteLine("Enter your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 99 && user_number < 1000)
{
    int result = MiddleDigit(user_number);
    Console.WriteLine($"Your middle number is: {result}");
}
else
{
    Console.WriteLine("Your number is not 3digits");
}