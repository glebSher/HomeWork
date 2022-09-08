// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (number > 0)
{
    while (count <= number)
    {
        double squareNumber = Math.Pow(count, 3);
        Console.Write(squareNumber + " ");
        count += 1;
    }
}
else
{
    Console.WriteLine("Введено некорретное число");
}