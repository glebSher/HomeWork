// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i=0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = GetArray(7, 100, 1000);
Console.WriteLine(string.Join(", ", array));

int FindEvenNumbers(int[] array)
{
    int amountEvNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        amountEvNum = amountEvNum + 1;
        }
    }
    return amountEvNum;
}

int amountEvenNumbers = FindEvenNumbers(array);
Console.WriteLine($"Количество четных числел в массиве = {amountEvenNumbers}");