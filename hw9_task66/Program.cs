// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumberMtoN (int m, int n)
{
    if (n == m)
    {
        return m;
    }
    else
    {
        return n + SumNumberMtoN (m, n - 1);
    }
}
int numberM = ReadNumber("Введите M");
int numberN = ReadNumber("Введите N");
int smNumbers = SumNumberMtoN(numberM, numberN);
Console.WriteLine ($"Сумма чисел от M до N = {smNumbers}");