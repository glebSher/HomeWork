// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());

int Max = 0;

if (numA > Max)
{
    Max = numA;
}
if (numB > Max)
{
    Max = numB;
}
if (numC > Max)
{
    Max = numC;
}
Console.Write("Max = ");
Console.WriteLine(Max);
