// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void MatrixSorting(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int min = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] < matr[i, min])
                {
                    min = k;
                }
            }
            int temp = matr[i, j];
            matr[i, j] = matr[i, min];
            matr[i, min] = temp;
        }
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
MatrixSorting(matrix);
PrintMatrix(matrix);
