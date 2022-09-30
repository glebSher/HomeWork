// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

int[,] matrix = new int[m, n];
int number = 1;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    matrix[0, i] = number;
    number++;
}
for (int j = 1; j < matrix.GetLength(0); j++)
{
    matrix[j, matrix.GetLength(1) - 1] = number;
    number++;
}
for (int i = matrix.GetLength(1) - 2; i >= 0; i--)
{
    matrix[matrix.GetLength(0) - 1, i] = number;
    number++;
}
for (int j = matrix.GetLength(0) - 2; j > 0; j--)
{
    matrix[j, 0] = number;
    number++;
}
int a = 1; // a, b - координаты ячейки, которая заполняется следующей
int b = 1;
while (number < m * n)
{
    while (matrix[a, b + 1] == 0)
    {
        matrix[a, b] = number;
        number++;
        b++;
    }
    while (matrix[a + 1, b] == 0)
    {
        matrix[a, b] = number;
        number++;
        a++;
    }
    while (matrix[a, b - 1] == 0)
    {
        matrix[a, b] = number;
        number++;
        b--;
    }
    while (matrix[a - 1, b] == 0)
    {
        matrix[a, b] = number;
        number++;
        a++;
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] = number;
        }
    }
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write($"{matrix[i, j]}  ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int m = ReadNumber("Введите количество строк:");
// int n = ReadNumber("Введите количество столбцов:");
// int[,] matrixix = GetSpiralmatrixix(m, n);
Printmatrix(matrix);
