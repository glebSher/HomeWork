// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}

else if (number > 999)
{
    while (number > 999)
    {
        int findNumber = number / 10;
        number = findNumber;
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}

else if (number > 0 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

else if (number < 0)
{
    Console.WriteLine("Введено отрицательное число");
}