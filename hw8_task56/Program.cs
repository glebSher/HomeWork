// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount,
                  int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumElementRow(int[,] matr)
{
    int minRow = 0;
    int sumElement = 0;
    int minSumElement = matr.GetLength(1) * 9; // максимально возможная сумма:
    // произведение количества элементов в строке на максимально возможное значение элемента
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumElement = sumElement + matr[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i} = {sumElement}");
        if (sumElement < minSumElement)
        {
            minRow = 0;
            minSumElement = sumElement;
            minRow = minRow + i;
        }
        sumElement = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов: {minSumElement}");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
MinSumElementRow(matrix);