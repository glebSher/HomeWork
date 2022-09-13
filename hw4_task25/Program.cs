// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberPow(int A, int B)
{
    int numPow = 1;
    while (B > 0)
    {
        numPow = numPow * A;
        B = B - 1;
    }
    return numPow;
}

int numberA = ReadNumber("Введите число A:");
int numberB = ReadNumber("Введите число B:");
int numberPow = NumberPow(numberA, numberB);
Console.WriteLine($"Число A в степени B: {numberPow}");