// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    int result = 1;
    if (m == 0 && n == 0) return result;
    else if (m == 0)
    {
        result = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        result = AkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        result = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    return result;
}

int numberM = ReadNumber("Введите M");
int numberN = ReadNumber("Введите N");
int akkermanFunction = AkkermanFunction(numberM, numberN);
Console.WriteLine($"A(m,n) = {akkermanFunction}");