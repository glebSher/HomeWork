// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

void ProdElements2Matrix(int[,] matrA, int[,] matrB)
{
    int[,] matrNew = new int[matrA.GetLength(0), matrA.GetLength(1)];
    int product = 0;
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrA.GetLength(1); j++)
        {
            product = product + matrA[i, j] * matrB[i, j];
            matrNew[i, j] = product;
            product = 0;
            if (matrNew[i, j] < 10)
            Console.Write(matrNew[i, j] + "  ");
            else Console.Write(matrNew[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matrixA = GetMatrix(m, n);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = GetMatrix(m, n);
PrintMatrix(matrixB);
Console.WriteLine();
ProdElements2Matrix(matrixA, matrixB);
