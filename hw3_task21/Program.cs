// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)+Math.Pow(zB - zA, 2));

Console.WriteLine($"Расстояние между точками равно {distance:f2}");