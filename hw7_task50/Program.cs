// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] GetMatrix (int rowsCount, int columnsCount, 
                  int leftRange, int rightRange)
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

void PrintMatrix (int[,] matr)
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

void FindMatrixElement (int [,] matr, 
                        int rowsPosition, 
                        int columnsPosition)
{
    if (rowsPosition < matr.GetLength(0)
        && rowsPosition >= 0
        && columnsPosition < matr.GetLength(1)
        && columnsPosition >= 0)
        {
            Console.WriteLine($"Значение элемента: {matr[rowsPosition, columnsPosition]}") ;
        }
    else Console.WriteLine("Такого элемента в массиве нет") ;
}

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = GetMatrix(5, 5, -100, 100);

PrintMatrix (matrix);

int m = ReadNumber("Введите номер строки:");
int n = ReadNumber("Введите номер столбца:");

FindMatrixElement (matrix, m, n);