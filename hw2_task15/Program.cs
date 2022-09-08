// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1 | number <= 5)
{
    Console.WriteLine("нет, этот день не выходной");
}
else if (number == 6 | number == 7)
{
    Console.WriteLine("да, этот день выходной");
}
else
{
    Console.WriteLine("В неделе всего 7 дней!!!");
}
