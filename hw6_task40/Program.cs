// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadNumber("Введите первое число:");
int numberB = ReadNumber("Введите второе число:");
int numberC = ReadNumber("Введите третье число:");

void ExamTriangle (int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A)
    {
        Console.WriteLine("Треугольник с такими сторонами может существовать");
    }
    else Console.WriteLine("Треугольник с такими сторонами не может существовать");
}

ExamTriangle(numberA, numberB, numberC);