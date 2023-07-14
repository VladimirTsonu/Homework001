// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DaysOfWeek (int number)
{
    if (number / 5 == 0 || number % 5 == 0)
    Console.WriteLine($"Your number {number} is work day");
    else if (number % 5 > 0)
    Console.WriteLine($"Your number {number} is day off");
}

 Console.WriteLine("Enter your number");
 int user_number = Convert.ToInt32(Console.ReadLine());

 if (user_number > 0 && user_number < 8)
    DaysOfWeek(user_number);
    else
    Console.WriteLine("Your number is not correct");