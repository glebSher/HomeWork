// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int[] array = GetArray(10, 1, 100);
Console.WriteLine(string.Join(", ", array));

int FindDiffMaxMin(int[] arr)
{
    int maxElement = array[0];
    int minElement = array[0];
    int diffMaxMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
        {
            maxElement = arr[i];
        }
        else if (arr[i] < minElement)
        {
            minElement = arr[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива = {maxElement}");
    Console.WriteLine($"Минимальный элемент массива = {minElement}");
    diffMaxMin = maxElement - minElement;
    return diffMaxMin;
}

int DifferenceMaxMin = FindDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifferenceMaxMin}");