// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double numB1 = ReadNumber("Введите значение b1:");
double numK1 = ReadNumber("Введите значение k1:");
double numB2 = ReadNumber("Введите значение b2:");
double numK2 = ReadNumber("Введите значение k2:");

if (numB1 != numB2 && numK1 != numK2)
{
    double pointX = 0;
    double pointY = 0;
    pointX = (numB2 - numB1) / (numK2 - numK1);
    pointY = (numK1 * numB2 - numK2 * numB1) / (numK2 - numK1);
    Console.WriteLine($"Точка пересечения прямых X = {pointX:f2}; Y = {pointY:f2}");
}
else if (numK1 == numK2 && numB1 != numB2)
{
    Console.WriteLine("Прямые параллельны");
}
else if (numK1 == numK2 && numB1 == numB2)
{
    Console.WriteLine("Прямые совпадают");
}