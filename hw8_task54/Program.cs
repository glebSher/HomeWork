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
        int min = matr[i, 0];
        // int max = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                int temp = matr[i, 0];
                matr[i, 0] = matr[i, j];
                matr[i, j] = temp;
            }
            else 
            // else if (matr[i, j] < max)
            // {
            //     max = matr[i, j];
            //     int temp = matr[i, matr.GetLength(1) - 1];
            //     matr[i, matr.GetLength(1) - 1] = matr[i, j];
            //     matr[i, j] = temp;
            // }
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
MatrixSorting(matrix);
