// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix (int rowsCount, int columnsCount, 
                     int leftRange = -10, int rightRange = 10)
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange) + rand.NextDouble();
        }
    }
    return matr;
}

void PrintMatrix (double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
int m = ReadNumber("Введите количество строк:");
int n= ReadNumber("Введите количество столбцов:");
double[,] matrix = GetMatrix(m, n);

PrintMatrix (matrix);