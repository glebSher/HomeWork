// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

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

void ColumnsArithmeticMean (int [,] matr)
{
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
        double arithMean = 0;
        double sum = 0;
        for (int rows = 0; rows < matr.GetLength(0); rows++)
        {
            sum = sum + matr[rows, columns];
        }
        arithMean = sum / matr.GetLength(0);
        Console.Write($"{arithMean:f1}; ");
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

int[,] matrix = GetMatrix(m, n, 1, 10);
PrintMatrix (matrix);

Console.Write("Среднее арифметические каждого столбца: ");
ColumnsArithmeticMean (matrix);