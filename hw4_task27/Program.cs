// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int N)
{
    int sum = 0;
    while (N != 0)
    {
        int digit = N % 10;
        sum = sum + digit;
        N = N / 10;
    }
    return sum;
}

int number = ReadNumber("Введите число N:");
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе N: {sumDigit}");