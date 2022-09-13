// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. 
// Данные вводятся с консоли пользователем

void CreateArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine("Введите следующее число массива");
        int arrayNumber = Convert.ToInt32(Console.ReadLine());
        array[index] = arrayNumber;
        index++;
    }
}

Console.WriteLine("Задайте размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arraySize];

CreateArray(Array);

Console.Write("Задан массив: ");
Console.WriteLine(string.Join(", ", Array));