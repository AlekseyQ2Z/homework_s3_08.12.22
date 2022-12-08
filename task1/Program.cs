// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int mirror = 0;
int temp;
int multiplier = 10000;
if (number > 9999 && number <= 99999)
{
    while (number2 > 0)
    {
        temp = number2 % 10;
        mirror = mirror + temp * multiplier;
        number2 = number2 / 10;
        multiplier = multiplier / 10;
    }
    if (mirror == number)
        Console.WriteLine("Число является палиндромом");
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}