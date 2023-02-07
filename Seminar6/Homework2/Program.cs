// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");

Console.Write("\nВведите b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("\nВведите k1: ");
Double k1 =  Convert.ToDouble(Console.ReadLine());
Console.Write("\nВведите b2: ");
Double b2 =  Convert.ToDouble(Console.ReadLine());
Console.Write("\nВведите k2: ");
Double k2 =  Convert.ToDouble(Console.ReadLine());
double x = ((b2 - b1) / (k1 - k2));
double y = k1 * x + b1;

Console.WriteLine("\n-------");
Console.WriteLine($"Точка пересечения: x= {x}, y= {y}");
