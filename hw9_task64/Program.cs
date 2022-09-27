// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumberNto1 (int n)
{
    if (n <= 0) return;
    else
    {
        Console.Write (n + " ");
        PrintNumberNto1(n - 1);
    }
}
int number = ReadNumber("Введите N");
PrintNumberNto1(number);