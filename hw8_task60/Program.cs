// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matrix = new int[2, 2, 2];
Random rand = new Random();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    int number = rand.Next(10, 100);
    if (array.Contains(number)) i--;
    else array[i] = number;
}

int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i, j, k] = array[count];
            count++;
            Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}
