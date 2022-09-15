// Задача 35: Задайте одномерный массив из 123 случайных чисел 
// в диапазоне [0, 150]. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int[] array = GetArray(123, 0, 150);
Console.WriteLine(string.Join(", ", array));

int FindAmountNumbers(int[] array)
{
    int amountNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
        amountNum = amountNum + 1;
        }
    }
    return amountNum;
}

int amountNumbers = FindAmountNumbers(array);
Console.WriteLine($"Количество искомых элементов в массиве = {amountNumbers}");